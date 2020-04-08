using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsIncluded.Models
{
    public class Asset : BaseEntity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<ImagePath> Images { get; set; }
    }
}
