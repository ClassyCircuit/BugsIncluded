using BugsIncluded.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsIncluded.ViewModels
{
    public class AssetPreviewViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ImagePath> Images { get; set; }

    }
}
