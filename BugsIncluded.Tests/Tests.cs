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
using System.Linq;

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
        public void CreateDummyImagePaths()
        {
            //var imageList = new List<ImagePath>()
            //{
            //    new ImagePath()
            //    {
            //        Name = "Jumping pad",
            //        ImageType = ImageType.NonAsset,
            //        Path = @"/images/Artboard 73.png"
            //    }
            //};

            //_ = assetService.AddImagePathAsync(imageList[0]).Result;
        }

        [Fact]
        public void CreateDummyAssets()
        {
            var assetList = new List<Asset>()
            {
                new Asset()
                {
                    Title = "Enchanted Forest",
                    Description = "Mystical forest pack",
                    Price = 14.99m,
                    Images = new List<ImagePath>()
                        {
                            new ImagePath()
                            {
                                Name = "Enchanted Forest",
                                ImageType = ImageType.Preview,
                                Path = @"/images/bg1.png"
                            },
                            new ImagePath()
                            {
                                Name = "Enchanted Forest Main",
                                ImageType = ImageType.Main,
                                Path = @"/images/efmain.png"
                            },
                            new ImagePath()
                            {
                                Name = "Enchanted Forest Spritesheet",
                                ImageType = ImageType.Side,
                                Path = @"/images/enchanted_nv.png"
                            },
                            new ImagePath()
                            {
                                Name = "Enchanted Forest a65",
                                ImageType = ImageType.Bottom,
                                Path = @"/images/Artboard 65.png"
                            },
                            new ImagePath()
                            {
                                Name = "Enchanted Forest a73",
                                ImageType = ImageType.Bottom,
                                Path = @"/images/Artboard 73.png"
                            },
                            new ImagePath()
                            {
                                Name = "Enchanted Forest 60",
                                ImageType = ImageType.Bottom,
                                Path = @"/images/Artboard 60.png"
                            }
                        }
                },
                new Asset()
                {
                    Title = "Low Poly",
                    Description = "Low poly land for 3d worlds",
                    Price = 14.99m,
                    Images = new List<ImagePath>()
                        {
                            new ImagePath()
                            {
                                Name = "Low Poly Land",
                                ImageType = ImageType.Preview,
                                Path = @"/images/bg3.png"
                            }
                        }
                },
                new Asset()
                {
                    Title = "Red Moon District",
                    Description = "Crow in sunset",
                    Price = 11.49m,
                    Images = new List<ImagePath>()
                        {
                            new ImagePath()
                            {
                                Name = "Red Moon",
                                ImageType = ImageType.Preview,
                                Path = @"/images/bg2.png"
                            }
                        }
                },
                new Asset()
                {
                    Title = "Mystical Flower",
                    Description = "Enchanted Forest Addon",
                    Price = 3.49m,
                    Images = new List<ImagePath>()
                        {
                            new ImagePath()
                            {
                                Name = "Flower",
                                ImageType = ImageType.Preview,
                                Path = @"/images/Flower1.png"
                            }
                        }
                },
                new Asset()
                {
                    Title = "Crystal Cave",
                    Description = "Stalagmitic cave pack",
                    Price = 5.49m,
                    Images = new List<ImagePath>()
                        {
                            new ImagePath()
                            {
                                Name = "Crystal cave",
                                ImageType = ImageType.Preview,
                                Path = @"/images/Artboard 68.png"
                            }
                        }
                },
                new Asset()
                {
                    Title = "Water Park",
                    Description = "Shark infested water pack",
                    Price = 7.49m,
                    Images = new List<ImagePath>()
                        {
                            new ImagePath()
                            {
                                Name = "Shark Water",
                                ImageType = ImageType.Preview,
                                Path = @"/images/Artboard 57.png"
                            }
                        }
                },
            };

            foreach (var item in assetList)
            {
                try
                {
                    _ = assetService.AddAssetAsync(item).Result;

                }
                catch (Exception ex)
                {
                    continue;
                }



            }
        }

        [Fact]
        public void GetTime()
        {
            DateTime now = DateTime.Now;
            Output.WriteLine(now.ToString());
        }
    }
}
