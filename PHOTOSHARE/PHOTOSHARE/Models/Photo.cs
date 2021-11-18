using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHOTOSHARE.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AlbumId { get; set; }
        public DateTime Created { get; set; }
        public string Image { get; set; }
    }
}
