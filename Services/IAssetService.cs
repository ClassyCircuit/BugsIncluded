using System.Collections.Generic;
using System.Threading.Tasks;
using BugsIncluded.Models;

namespace BugsIncluded.Services
{
    public interface IAssetService
    {
        Task<int> AddAssetAsync(Asset asset);
        Task<List<Asset>> GetAllAssetsAsync();
        Task<int> AddImagePathAsync(ImagePath imagePath);
        Task<List<ImagePath>> GetAllImagePathsAsync();
        Task<Asset> GetAssetAsync(int id);
    }
}