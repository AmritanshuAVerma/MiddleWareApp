using Microsoft.AspNetCore.Mvc;

namespace MiddleWareApp.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/error")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public void TraceError()
        {
            //Write logic to log error
        }
    }
}
