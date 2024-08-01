using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Net.Events
{
    public class AppointmentCreatedEvent : IEvent
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime AppointmentDate { get; set; }

        public AppointmentStatus Status { get; set; }



    }
}
