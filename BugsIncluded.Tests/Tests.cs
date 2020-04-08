using BugsIncluded.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using BugsIncluded.ViewModels;
using Moq;
using Microsoft.Extensions.Logging;
using System;
using Xunit.Abstractions;
using BugsIncluded.Services;
using BugsIncluded.Models;
using System.Collections.Generic;
using BugsIncluded.Data;
using Microsoft.EntityFrameworkCore;

namespace BugsIncluded.Tests
{
    public class Tests
    {
        private readonly IAssetService assetService;

        public ITestOutputHelper Output { get; }

        public Tests(ITestOutputHelper output)
        {
            Output = output;
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlite("Data Source=C:\\Code\\BugsIncluded\\BugsIncluded.db");
            this.assetService = new AssetService(new AppDbContext(builder.Options));
        }

        [Fact]
        public void CreateDummyAssets()
        {
            var asset = new Asset()
            {
                Title = "Purple Desert",
                Description = "Purplish sprites in this pack",
                Price = 14.99m,
                Images = new List<ImagePath>()
                {
                    new ImagePath()
                    {
                        ImageType = ImageType.preview,
                        Path = @"~/images/bg1.png"
                    }
                }
            };
            _ = assetService.AddAssetAsync(asset).Result;
        }

        [Fact]
        public void GetTime()
        {
            DateTime now = DateTime.Now;
            Output.WriteLine(now.ToString());
        }
    }
}
