using Microsoft.AspNetCore.Mvc;
using MVC_Core.Models.HelloWorld;

namespace MVC_Core.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            var model = new Welcome
            {
                Message = $"Hello, {name}.",
                NumTimes = numTimes
            };
            return View(model);
        }
    }
}
