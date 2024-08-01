using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Net.Events
{
    public class AppointmentDateUpdatedEvent : IEvent
    {
        public Guid Id { get; set; }

        public DateTime AppointmentDate { get; set; }

    }
}
