using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.DbContexts.Concrete;
using WorkoutTracker.Core.Implementation.QueryHandlers;
using WorkoutTracker.Core.Implementation.QueryHandlers.Abstract;
using System.Collections.Generic;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.ActionDispatchers.Concrete;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateActionHandlers;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries;
using WorkoutTracker.Core.Implementation.QueryHandlers.Concrete;
using WorkoutTracker.Core.Implementation.Queries.Concrete;

namespace WorkoutTracker.Api
{
    public static class AutoFacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            RegisterTypes(builder);

            var container = builder.Build();

            var config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<WorkoutDbContext>().As<ICommandDbContext>().InstancePerRequest();
            builder.RegisterType<WorkoutDbContext>().As<IQueryDbContext>().InstancePerRequest();
            builder.RegisterType<AddWorkoutTemplateActionHandler>().As<IActionHandler<AddWorkoutTemplateAction>>().InstancePerRequest();
            builder.RegisterType<WorkoutTemplateActionDispatcher>().As<IWorkoutTemplateActionDispatcher>().InstancePerRequest();
            builder.RegisterType<WorkoutTemplateQueryHandler>().As<IQueryHandler<WorkoutTemplateQuery, IEnumerable<WorkoutTemplate>>>().InstancePerRequest();
            builder.RegisterType<ExerciseQueryHandler>().As<IQueryHandler<ExerciseQuery, IEnumerable<Exercise>>>().InstancePerRequest();
        }
    }
}