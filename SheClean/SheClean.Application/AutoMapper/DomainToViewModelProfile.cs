using AutoMapper;
using SheClean.Application.ViewModels;
using SheClean.Domain.Models;

namespace SheClean.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Patient, PatientViewModel>();
        }
    }
}