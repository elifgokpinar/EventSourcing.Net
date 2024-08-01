using EventSourcing.Net.Events;
using EventStore.ClientAPI;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text;
using System.Text.Json;

namespace EventSourcing.API.EventStores
{
    public abstract class AbstractStream
    {

        protected readonly LinkedList<IEvent> Events = new LinkedList<IEvent>();

        private string _streamName { get; }

        private readonly IEventStoreConnection _eventStoreConnection;

        protected AbstractStream(string streamName, IEventStoreConnection eventStoreConnection)
        {
            this._streamName = streamName;
            this._eventStoreConnection = eventStoreConnection;
        }

        public async Task SaveAsync()
        {
            var newEvent = Events.ToList().Select(x => new EventData(
                Guid.NewGuid(),
                x.GetType().Name,
                true,
                Encoding.UTF8.GetBytes(JsonSerializer.Serialize(x, inputType: x.GetType())),
                Encoding.UTF8.GetBytes(x.GetType().FullName))).ToList();

            await _eventStoreConnection.AppendToStreamAsync(_streamName, ExpectedVersion.Any, newEvent);

            Events.Clear(); //Eventler Event Store'a kaydedildikten sonra silinir.
            
        }

    }
}
