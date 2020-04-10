using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BugsIncluded.Models;
using BugsIncluded.ViewModels;
using BugsIncluded.Services;

namespace BugsIncluded.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAssetService assetService;

        public HomeController(ILogger<HomeController> logger, IAssetService assetService)
        {
            _logger = logger;
            this.assetService = assetService;
        }

        public async Task<IActionResult> AssetPreview()
        {
            var assetModels = assetService.GetAllAssetsAsync();
            var viewModel = Mapper.AssetToAssetPreview(assetModels.Result);
            return View(viewModel);
        }

        public async Task<IActionResult> Blog()
        {
            CardHolderViewModel cardHolderViewModel = new CardHolderViewModel()
            {
                CardViewModels = new List<CardViewModel>()
                {
                    new CardViewModel()
                    {
                        Title = "Blog posts coming soon",
                        LastUpdated = DateTime.Today
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
