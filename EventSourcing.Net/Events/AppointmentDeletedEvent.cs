using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Net.Events
{
    public class AppointmentDeletedEvent : IEvent
    {
        public Guid Id { get; set; }

    }
}
