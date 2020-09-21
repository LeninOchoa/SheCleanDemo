using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SheClean.Application.AutoMapper;

namespace SheClean.MVC.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(SheClean.Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappigs();
        }
    }
}