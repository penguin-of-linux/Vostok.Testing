using Microsoft.ApplicationInsights.AspNetCore.Extensions;
using Microsoft.AspNetCore.Mvc;
using Vostok.Tracing;

namespace Sample.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("{*url}")]
        public object Echo()
        {
            for (int i = 0; i < 1000000; i ++) ;
            return 42;
        }
    }
}
