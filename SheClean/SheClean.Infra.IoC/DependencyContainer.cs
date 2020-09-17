using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SheClean.Application.Interfaces;
using SheClean.Application.Services;
using SheClean.Domain.CommandHandlers;
using SheClean.Domain.Commands;
using SheClean.Domain.Core.Bus;
using SheClean.Domain.Interfaces;
using SheClean.Infra.Bus;
using SheClean.Infra.Data.Context;
using SheClean.Infra.Data.Repository;

namespace SheClean.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemory MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handler
            services.AddScoped<IRequestHandler<CreatePatientCommand,bool>, PatientCommandHandler>();

            //Application Layer
            services.AddScoped<IPatientService, PatientService>();

            //Infra.Data Layer
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<SheDbContext>();

        }
    }
}