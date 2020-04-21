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
        public static List<AssetViewModel> ToAssetViewModelList(List<Asset> assetModels)
        {
            var viewModelList = new List<AssetViewModel>();
            foreach (var asset in assetModels)
            {
                viewModelList.Add(ToAssetViewModel(asset));
            }

            return viewModelList;
        }

        public static AssetViewModel ToAssetViewModel(Asset asset)
        {
            return new AssetViewModel()
            {
                Id = asset.Id,
                Title = asset.Title,
                Images = asset.Images,
                Price = asset.Price,
                Description = asset.Description
            };
        }
    }
}
