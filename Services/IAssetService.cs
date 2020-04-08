using System.Collections.Generic;
using System.Threading.Tasks;
using BugsIncluded.Models;

namespace BugsIncluded.Services
{
    public interface IAssetService
    {
        Task<int> AddAssetAsync(Asset asset);
        Task<List<Asset>> GetAllAssetsAsync();
    }
}