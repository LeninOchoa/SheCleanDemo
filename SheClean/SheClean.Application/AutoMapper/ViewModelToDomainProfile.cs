using AutoMapper;
using SheClean.Application.ViewModels;
using SheClean.Domain.Commands;

namespace SheClean.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<PatientViewModel, CreatePatientCommand>()
                .ConvertUsing(c => new CreatePatientCommand(c.Nachname,c.Vorname, c.ImageUrl));
        }
    }
}