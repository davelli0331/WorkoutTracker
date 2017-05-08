using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Concrete;
using WorkoutTracker.Core.Implementation.ActionHandlerFactory.Abstract;
using WorkoutTracker.Core.Implementation.ActionHandlerFactory.Concrete;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.DbContexts.Concrete;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries.Concrete;
using WorkoutTracker.Core.Implementation.QueryHandlers.Abstract;
using WorkoutTracker.Core.Implementation.QueryHandlers.Concrete;

namespace WorkoutTracker.Api.NetCore.Configuration
{
    internal static class DependencyMappingConfiguration
    {
        internal static void AddDependencyMapping(this IServiceCollection services)
        {
            services.AddTransient<ICommandDbContext, WorkoutDbContext>();
            services.AddTransient<IQueryDbContext, WorkoutDbContext>();
            services.AddTransient<IActionHandler<AddWorkoutTemplateAction>, AddWorkoutTemplateActionHandler>();
            services.AddTransient<IWorkoutTemplateActionDispatcher, WorkoutTemplateActionDispatcher>();
            services.AddTransient<IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>>, WorkoutTemplateQueryHandler>();
            services.AddTransient<IQueryHandler<ExerciseQuery, IEnumerable<Exercise>>, ExerciseQueryHandler>();
            services.AddTransient<IActionHandlerFactory, ActionHandlerFactory>();
        }
    }
}
