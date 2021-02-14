using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConfigureSample.Models;
using Microsoft.Extensions.Options;

namespace ConfigureSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _options;
        private readonly Section _section;

        public HomeController(IOptions<AppSettings> options, IOptions<Section> section)
        {
             _options = options.Value;
            this._section = section.Value;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = _options.Bar;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
