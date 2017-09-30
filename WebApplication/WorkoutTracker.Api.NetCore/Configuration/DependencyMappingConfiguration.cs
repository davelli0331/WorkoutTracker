using MediatR;
using Microsoft.Extensions.DependencyInjection;
using WorkoutTracker.Core.NetCore.DbContexts.Abstract;
using WorkoutTracker.Core.NetCore.DbContexts.Concrete;

namespace WorkoutTracker.Api.NetCore.Configuration
{
    internal static class DependencyMappingConfiguration
    {
        internal static IServiceCollection AddDependencyMapping(this IServiceCollection services)
        {
            services.AddScoped<IMediator, Mediator>();
            services.AddTransient<SingleInstanceFactory>(sp => t => sp.GetService(t));
            services.AddTransient<MultiInstanceFactory>(sp => t => sp.GetServices(t));
            services.AddTransient<ICommandDbContext, WorkoutDbContext>();
            services.AddTransient<IQueryDbContext, WorkoutDbContext>();

            return services;
        }
    }
}
