using System;
using System.Collections.Generic;

namespace PHOTOSHARE.Models
{
    public class AlbumImage
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime created_at { get; set; }
        public string created_by { get; set; }
        public string album_art { get; set; }
    }
}
