using Microsoft.Extensions.DependencyInjection;
using WorkoutTracker.Core.NetCore.DbContexts.Abstract;
using WorkoutTracker.Core.NetCore.DbContexts.Concrete;

namespace WorkoutTracker.Api.NetCore.Configuration
{
    internal static class DependencyMappingConfiguration
    {
        internal static IServiceCollection AddDependencyMapping(this IServiceCollection services)
        {
            services.AddTransient<ICommandDbContext, WorkoutDbContext>();
            services.AddTransient<IQueryDbContext, WorkoutDbContext>();

            return services;
        }
    }
}
