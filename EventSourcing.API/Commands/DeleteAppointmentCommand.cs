using EventSourcing.API.Dtos;
using MediatR;

namespace EventSourcing.API.Commands
{
    public class DeleteAppointmentCommand: IRequest
    {
        public Guid Id { get; set; }

    }
}
