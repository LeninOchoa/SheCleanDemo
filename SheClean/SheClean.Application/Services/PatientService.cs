using System.Collections.Generic;
using SheClean.Application.Interfaces;
using SheClean.Application.ViewModels;
using SheClean.Domain.Interfaces;

namespace SheClean.Application.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public PatientViewModel GetPatients()
        {
            return new PatientViewModel()
            {
                Patients = _patientRepository.GetPatients()
            };
        }
    }
}