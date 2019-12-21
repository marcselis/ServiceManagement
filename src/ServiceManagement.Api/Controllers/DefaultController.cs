using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;

namespace ServiceManagement.Api
{
    /// <summary>
    /// Default controller that handles requests on root
    /// </summary>
    [Route("")]
    public class DefaultController : ControllerBase
    {
        /// <summary>
        /// Handles a GET on the program root
        /// </summary>
        /// <returns>A redirection to the swagger documentation</returns>
        public ActionResult Get()
        {
            return LocalRedirect("~/swagger");
        }

        /// <summary>
        /// Handles the HTTP OPTIONS call on root
        /// </summary>
        /// <returns>A 200:OK response with the supported HTTP verbs</returns>
        [HttpOptions]
        public IActionResult Options()
        {
            using (var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(string.Empty) })
            {
                response.Content.Headers.Add("Allow", new[] { "GET", "POST", "OPTIONS" });
                response.Content.Headers.ContentType = null;
                return Ok(response);
            }
        }
    }
}