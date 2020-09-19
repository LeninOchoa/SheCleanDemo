using SheClean.Application.Interfaces;
using SheClean.Application.ViewModels;
using SheClean.Domain.Commands;
using SheClean.Domain.Core.Bus;
using SheClean.Domain.Interfaces;

namespace SheClean.Application.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMediatorHandler _bus;

        public PatientService(IPatientRepository patientRepository, IMediatorHandler bus)
        {
            _patientRepository = patientRepository;
            _bus = bus;
        }

        public PatientViewModel GetPatients()
        {
            return new PatientViewModel()
            {
                Patients = _patientRepository.GetPatients()
            };
        }

        public void Create(PatientViewModel patientViewModel)
        {
            var createPatientCommand = new CreatePatientCommand(
                patientViewModel.Nachname,
                patientViewModel.Vorname,
                patientViewModel.ImageUrl);

            _bus.SendCommand(createPatientCommand);
        }
    }
}