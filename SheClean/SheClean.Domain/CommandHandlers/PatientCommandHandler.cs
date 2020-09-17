using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SheClean.Domain.Commands;
using SheClean.Domain.Interfaces;
using SheClean.Domain.Models;

namespace SheClean.Domain.CommandHandlers
{
    public class PatientCommandHandler : IRequestHandler<CreatePatientCommand, bool>
    {
        private readonly IPatientRepository _patientRepository;

        public PatientCommandHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public Task<bool> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            var patient = new Patient()
            {
                Vorname = request.Vorname,
                Nachname = request.Nachname,
                ImageUrl = request.ImageUrl
            };

            _patientRepository.Add(patient);

            return Task.FromResult(true);
        }
    }
}