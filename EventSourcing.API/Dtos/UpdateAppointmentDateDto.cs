using EventSourcing.Net.Events;

namespace EventSourcing.API.Dtos
{
    public class UpdateAppointmentDateDto
    {
        public Guid Id { get; set; }

        public DateTime AppointmentDate { get; set; }

    }
}
