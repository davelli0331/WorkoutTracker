using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using WorkoutTracker.Core.Implementation.ActionHandlers.Abstract;
using WorkoutTracker.Core.Implementation.ActionHandlers.Concrete.WorkoutTemplateCommands;
using WorkoutTracker.Core.Implementation.Actions.WorkoutTemplateActions;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Abstract;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Concrete;
using WorkoutTracker.Core.Implementation.DbContexts.Abstract;
using WorkoutTracker.Core.Implementation.DbContexts.Concrete;

namespace WorkoutTracker.Api
{
    public static class AutoFacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<CommandDbContext>().As<ICommandDbContext>().InstancePerRequest();
            builder.RegisterType<AddWorkoutTemplateActionHandler>().As<IActionHandler<AddWorkoutTemplateAction>>().InstancePerRequest();
            builder.RegisterType<WorkoutTemplateCommandDispatcher>().As<IWorkoutTemplateCommandDispatcher>().InstancePerRequest();

            var container = builder.Build();

            var config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}