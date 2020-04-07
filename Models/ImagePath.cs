using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsIncluded.Models
{
    public enum ImageType
    {
        preview,
        main,
        secondary
    }
    public class ImagePath
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public ImageType ImageType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
