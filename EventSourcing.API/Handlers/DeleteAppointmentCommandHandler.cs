using EventSourcing.API.Commands;
using EventSourcing.API.EventStores;
using MediatR;

namespace EventSourcing.API.Handlers
{
    public class DeleteAppointmentCommandHandler : IRequestHandler<DeleteAppointmentCommand>
    {
        private readonly AppointmentStream _appointmentStream;

        public DeleteAppointmentCommandHandler(AppointmentStream appointmentStream)
        {
            _appointmentStream = appointmentStream;
        }

        public async Task<Unit> Handle(DeleteAppointmentCommand request, CancellationToken cancellationToken)
        {
            _appointmentStream.Deleted(request.Id);

            await _appointmentStream.SaveAsync();

            return Unit.Value;
        }
    }
}
