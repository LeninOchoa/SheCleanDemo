using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _autoMapper;

        public PatientService(IPatientRepository patientRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _patientRepository = patientRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public IEnumerable<PatientViewModel> GetPatients()
        {
            return _patientRepository.GetPatients().ProjectTo<PatientViewModel>(_autoMapper.ConfigurationProvider);
        }

        public void Create(PatientViewModel patientViewModel)
        {
            //var createPatientCommand = new CreatePatientCommand(
            //    patientViewModel.Nachname,
            //    patientViewModel.Vorname,
            //    patientViewModel.ImageUrl);

            _bus.SendCommand(_autoMapper.Map<CreatePatientCommand>(patientViewModel));
        }
    }
}