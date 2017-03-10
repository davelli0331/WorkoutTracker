using System.Web.Http;
using WorkoutTracker.Api.App_Start;

namespace WorkoutTracker.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoFacConfig.Configure();
        }
    }
}
