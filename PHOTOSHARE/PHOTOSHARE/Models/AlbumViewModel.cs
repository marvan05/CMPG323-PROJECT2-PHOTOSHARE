﻿using PHOTOSHARE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PHOTOSHARE.Models
{
    public class AlbumViewModel 
    {

        public List<Album> Albums { get; set; }

        public Album Album { get; set; }

        public AlbumViewModel()
        {

        }

        public AlbumViewModel(PHOTOSHAREDBContext context)
        {
            Albums = context.Albums.ToList();
        }
    }
}