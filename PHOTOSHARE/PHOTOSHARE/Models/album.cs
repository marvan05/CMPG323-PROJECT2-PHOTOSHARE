using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHOTOSHARE.Models
{
    public class album
    {
        public int id { get; set; }
        public string created_by { get; set; }
        public string title { get; set; }
        public DateTime created_at { get; set; }
        public string album_art { get; set; }
    }
}
