//////////////////////////////////////////////////////////////////
//
//   PROGRAMMING ASP.NET CORE
//   Dino Esposito
//   
//   Ch07 - Design Considerations
//   Config
//  

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Ch07.Config.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfigurationRoot _config;

        public HomeController(IConfigurationRoot config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            ViewData["PageSize"] = _config.GetValue<int>("GeneralSettings:Paging:PageSize");
            return View();
        }
    }
}