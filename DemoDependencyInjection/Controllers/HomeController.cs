using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoDependencyInjection.Models;
using DemoDependencyInjection.CustomServices;
using Microsoft.AspNetCore.Http;
using DemoDependencyInjection.Providers;

namespace DemoDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RandomStringService _randomStringService;
        private readonly IDataProvider _dataProvider;

        public HomeController(ILogger<HomeController> logger, RandomStringService randomStringSService, IDataProvider dataProvider)
        {
            _logger = logger;
            _randomStringService = randomStringSService;
            _dataProvider = dataProvider;
        }

        public IActionResult Index()
        {
            HttpContext.Response.WriteAsync($"Random Value from HomeController/Index :- {_randomStringService.ShowRandomString()}  \n");
            _dataProvider.WriteLog();
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
