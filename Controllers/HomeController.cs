using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BugsIncluded.Models;
using BugsIncluded.ViewModels;

namespace BugsIncluded.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CardHolderViewModel cardHolderViewModel = new CardHolderViewModel()
            {
                CardViewModels = new List<CardViewModel>()
                {
                    new CardViewModel()
                    {
                        Title = "Configuring Raspberry Pi DNS Server",
                        LastUpdated = DateTime.Today
                    },
                    new CardViewModel()
                    {
                        Title = "Running Teradata Express on Azure",
                        LastUpdated = DateTime.Today.AddDays(-5)
                    }
                }
            };

            return View(cardHolderViewModel);
        }

        public IActionResult About()
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
