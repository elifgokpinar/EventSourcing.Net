using EventSourcing.API.Commands;
using EventSourcing.API.EventStores;
using MediatR;

namespace EventSourcing.API.Handlers
{
    public class CreateAppointmentCommandHandler : IRequestHandler<CreateAppointmentCommand>
    {
        private readonly AppointmentStream _appointmentStream;

        public CreateAppointmentCommandHandler(AppointmentStream appointmentStream)
        {
            _appointmentStream = appointmentStream;
        }

        public async Task<Unit> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            _appointmentStream.Created(request.CreateAppointmentDto);

            await _appointmentStream.SaveAsync();

            return Unit.Value; // MediatR'da hiçbir şey dönmeyeceksek Unit.Value dönebiliriz.
        }
    }
}
