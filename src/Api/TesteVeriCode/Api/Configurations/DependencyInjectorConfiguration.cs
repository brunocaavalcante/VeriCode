using AutoMapper;
using Business.Interfaces;
using Business.Services;
using Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public static class DependencyInjectorConfiguration
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IFaturaRepository, FaturaRepository>();
            services.AddScoped<IFaturaService, FaturaService>();
            return services;
        }
    }
}
