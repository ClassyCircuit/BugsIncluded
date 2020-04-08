using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsIncluded.Models
{
    public class ImagePath : BaseEntity
    {
        public string Path { get; set; }
        public ImageType ImageType { get; set; }
    }
}
