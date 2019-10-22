using Microsoft.AspNetCore.Mvc;

namespace ServiceManagement.Api
{
    /// <summary>
    /// Controller class to handle requests regarding builds
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [Route("v{version:apiVersion}/[controller]")]
    public class BuildsController : ControllerBase
    {
        /// <summary>
        /// Adds a new build result to the system.
        /// </summary>
        /// <param name="build">The <see cref="BuildResult"/> instance to add to the system.</param>
        /// <returns></returns>
        [HttpPost]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        public ActionResult AddBuildResult(BuildResult build)
        {
            if (build is null)
            {
                return ValidationProblem("No content specified");
            }

            return Ok();
        }
    }
}