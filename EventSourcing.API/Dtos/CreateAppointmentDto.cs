using EventSourcing.Net.Events;

namespace EventSourcing.API.Dtos
{
    public class CreateAppointmentDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime AppointmentDate { get; set; }

        public AppointmentStatus Status { get; set; }
    }
}
