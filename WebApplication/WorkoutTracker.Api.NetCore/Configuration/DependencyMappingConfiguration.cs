using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Abstract;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Concrete;
using WorkoutTracker.Core.NetCore.ActionHandlerFactory.Abstract;
using WorkoutTracker.Core.NetCore.ActionHandlerFactory.Concrete;
using WorkoutTracker.Core.NetCore.ActionHandlers.Abstract;
using WorkoutTracker.Core.NetCore.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.NetCore.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.NetCore.DbContexts.Abstract;
using WorkoutTracker.Core.NetCore.DbContexts.Concrete;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.Queries.Concrete;
using WorkoutTracker.Core.NetCore.QueryHandlers.Abstract;
using WorkoutTracker.Core.NetCore.QueryHandlers.Concrete;

namespace WorkoutTracker.Api.NetCore.Configuration
{
    internal static class DependencyMappingConfiguration
    {
        internal static IServiceCollection AddDependencyMapping(this IServiceCollection services)
        {
            services.AddTransient<ICommandDbContext, WorkoutDbContext>();
            services.AddTransient<IQueryDbContext, WorkoutDbContext>();
            services.AddTransient<IActionHandler<AddWorkoutTemplateAction>, AddWorkoutTemplateActionHandler>();
            services.AddTransient<IWorkoutTemplateActionDispatcher, WorkoutTemplateActionDispatcher>();
            services.AddTransient<IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>>, WorkoutTemplateQueryHandler>();
            services.AddTransient<IQueryHandler<ExerciseQuery, IEnumerable<Exercise>>, ExerciseQueryHandler>();
            services.AddTransient<IActionHandlerFactory, ActionHandlerFactory>();

            return services;
        }
    }
}
