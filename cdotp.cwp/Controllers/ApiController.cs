using System.Diagnostics;
using cdotp.cwp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cdotp.cwp.Controllers
{
    public class ApiController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ApiController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            return "Hi";
        }

        public string FunctionTwo()
        {
            return "two";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}