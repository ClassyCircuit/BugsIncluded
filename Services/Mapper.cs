using BugsIncluded.Models;
using BugsIncluded.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsIncluded.Services
{
    /// <summary>
    /// Map model to viewmodel
    /// </summary>
    public static class Mapper
    {
        public static List<AssetPreviewViewModel> AssetToAssetPreview(List<Asset> assetModels)
        {
            var viewModel = new List<AssetPreviewViewModel>();
            foreach (var asset in assetModels)
            {
                viewModel.Add(new AssetPreviewViewModel()
                {
                    Id = asset.Id,
                    Title = asset.Title,
                    Images = asset.Images,
                    Price = asset.Price
                });
            }

            return viewModel;
        }
    }
}
