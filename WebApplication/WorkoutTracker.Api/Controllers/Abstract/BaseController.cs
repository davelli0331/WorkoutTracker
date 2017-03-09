using System.Web.Http;
using WorkoutTracker.Core.Implementation.CommandDispatchers.Utility;

namespace WorkoutTracker.Api.Controllers.Abstract
{
    public class BaseController : ApiController
    {
        protected IHttpActionResult Result(DispatchResult result)
        {
            if (result.Succeeded)
            {
                return Ok();
            }

            return InternalServerError(result.CaughtException);
        }
    }
}