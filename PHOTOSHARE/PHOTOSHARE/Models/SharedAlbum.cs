using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHOTOSHARE.Models
{
    public class SharedAlbum
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Owner { get; set; }
        public string SharedWith { get; set; }
        public DateTime SharedDate { get; set; }
        public Album Album { get; set; }
    }
}
