using EventSourcing.API.Dtos;
using MediatR;

namespace EventSourcing.API.Commands
{
    public class updateAppointmentDateCommand: IRequest
    {
        public UpdateAppointmentDateDto UpdateAppointmentDateDto { get; set; }

    }
}
