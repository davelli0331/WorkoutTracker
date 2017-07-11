using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Core.NetCore.ActionDispatchers.Utility;

namespace WorkoutTracker.Api.NetCore.Controllers.Abstract
{
    public class BaseController : Controller
    {
        protected ActionResult Result(DispatchResult result)
        {
            if (result.Succeeded)
            {
                return Ok();
            }

            return StatusCode(500, result.CaughtException);
        }
    }
}