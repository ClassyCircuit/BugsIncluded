using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsIncluded.Models
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Contents { get; set; }
    }
}
