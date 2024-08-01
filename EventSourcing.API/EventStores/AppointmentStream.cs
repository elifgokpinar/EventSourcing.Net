using EventSourcing.API.Dtos;
using EventSourcing.Net.Events;
using EventStore.ClientAPI;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text;
using System.Text.Json;

namespace EventSourcing.API.EventStores
{
    public abstract class AppointmentStream : AbstractStream
    {


        public static string StreamName = "ProductStream";

        private readonly IEventStoreConnection _eventStoreConnection;

        protected AppointmentStream(IEventStoreConnection eventStoreConnection):base(StreamName,eventStoreConnection)
        {
        }

        //Create appointment event
        public void Created(CreateAppointmentDto request)
        {

            var appointmentEvent = new AppointmentCreatedEvent
            {
                Id = Guid.NewGuid(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                Description = request.Description,
                Price = request.Price,
                Status = AppointmentStatus.New,
                AppointmentDate = DateTime.Now,
                CreatedAt = DateTime.Now,
            };

            Events.AddLast(appointmentEvent);
            
        }

        //Update appointment date event
        public void UpdateAppointmentDate(UpdateAppointmentDateDto request)
        {
            var appointmentEvent = new AppointmentDateUpdatedEvent 
            { 
                Id = Guid.NewGuid(), 
                AppointmentDate = DateTime.Now 
            };

            Events.AddLast(appointmentEvent);
        }

        public void Deleted(Guid id)
        {
            var appointmentEvent = new AppointmentDeletedEvent
            {
                Id = id
            };

            Events.AddLast(appointmentEvent);
        }


    }
}
