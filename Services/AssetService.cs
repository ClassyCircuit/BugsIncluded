using BugsIncluded.Data;
using BugsIncluded.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsIncluded.Services
{
    public class AssetService : IAssetService
    {
        private readonly AppDbContext _context;

        public AssetService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Asset>> GetAllAssetsAsync()
        {
            return await _context.Assets.Include(x => x.Images).ToListAsync();
        }

        public async Task<int> AddAssetAsync(Asset asset)
        {
            _context.Add(asset);
            return await _context.SaveChangesAsync();
        }

    }
}
