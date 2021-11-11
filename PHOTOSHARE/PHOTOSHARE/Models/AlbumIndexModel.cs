using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHOTOSHARE.Models
{
    public class AlbumIndexModel
    {
        public IEnumerable<AlbumImage> Albums { get; set; }
        public string SearchQuery { get; set; }
    }
}
