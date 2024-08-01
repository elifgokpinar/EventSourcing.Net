using EventSourcing.API.Dtos;
using MediatR;

namespace EventSourcing.API.Commands
{
    public class CreateAppointmentCommand: IRequest
    {
        public CreateAppointmentDto CreateAppointmentDto { get; set; }
    }
}
