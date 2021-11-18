using PHOTOSHARE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHOTOSHARE.Models
{
    public class PhotoViewModel
    {
        public List<Photo> Photos { get; set; }
        public Photo Photo { get; set; }
        public int AlbumId { get; set; }

        public PhotoViewModel() { }

        public PhotoViewModel(PHOTOSHAREDBContext context, int albumId) 
        {
            Photos =  context.Photo.Where(p => p.AlbumId == albumId).ToList();
            AlbumId = albumId;
        }

        public static PhotoViewModel GetPhoto(PHOTOSHAREDBContext context, int photoId)
        {
            return new PhotoViewModel
            {
                Photo = context.Photo.Where(p => p.Id == photoId).SingleOrDefault(),
        };
        }

    }
}
