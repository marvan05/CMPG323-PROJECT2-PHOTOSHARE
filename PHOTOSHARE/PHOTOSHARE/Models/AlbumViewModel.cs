using Microsoft.EntityFrameworkCore;
using PHOTOSHARE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PHOTOSHARE.Models
{
    public class AlbumViewModel 
    {

        public List<Album> MyAlbums { get; set; }
        public List<Album> SharedAlbums { get; set; }

        public Album Album { get; set; }

        public AlbumViewModel() { }

        public AlbumViewModel(PHOTOSHAREDBContext context, string userName)
        {
            MyAlbums = context.Albums.Where(a => a.Owner == userName).ToList();
            var albumIds = context.SharedAlbum.Where(s => s.SharedWith == userName).Select(a => a.AlbumId).ToList();
            SharedAlbums = context.Albums.Where(a => albumIds.Contains(a.Id)).ToList();
        }

        public static AlbumViewModel GetAlbum(PHOTOSHAREDBContext context, int albumId)
        {
            return new AlbumViewModel
            {
                Album = context.Albums.Where(a => a.Id == albumId).FirstOrDefault(),
            };

        }
    }
}