using Microsoft.AspNetCore.Mvc;
using PHOTOSHARE.Data;
using PHOTOSHARE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHOTOSHARE.Controllers
{
    public class AlbumController : Controller
    {
        private readonly PHOTOSHAREDBContext _context;

        public AlbumController(PHOTOSHAREDBContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            return View(new AlbumViewModel(_context));
        }

        public PartialViewResult CreateAlbum()
        {
            var albumViewModel = new AlbumViewModel();
            return PartialView("_AddEditAlbum", albumViewModel);
        }

        [HttpPost]
        public ViewResult CreateAlbum(string title, string image)
        {
            var album = new Album
            {
                Title = title,
                Owner = User.Identity.Name.ToString(),
                Created = DateTime.Now,
                Image = image,
            };
            _context.Albums.Add(album);
            _context.SaveChanges();
            return View();
        }
    }
}

