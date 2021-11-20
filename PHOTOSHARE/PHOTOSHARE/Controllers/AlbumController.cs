using Microsoft.AspNetCore.Mvc;
using PHOTOSHARE.Data;
using PHOTOSHARE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            return View(new AlbumViewModel(_context, User.Identity.Name.ToString()));
        }

        public PartialViewResult CreateAlbum()
        {
            var albumViewModel = new AlbumViewModel();
            return PartialView("_AddEditAlbum", albumViewModel);
        }

        [HttpPost]
        public HttpStatusCode ShareAlbum(int albumId, string username)
        {
            var user = _context.Users.Where(u => u.UserName == username).FirstOrDefault();
            if (user != null && User.Identity.Name.ToString() != username)
            {
                try
                {
                    var shareAlbum = new SharedAlbum
                    {
                        AlbumId = albumId,
                        Owner = User.Identity.Name.ToString(),
                        SharedDate = DateTime.Now,
                        SharedWith = username,
                    };
                    _context.SharedAlbum.Add(shareAlbum);
                    _context.SaveChangesAsync();
                    return HttpStatusCode.OK;
                }
                catch (Exception)
                {
                    return HttpStatusCode.BadRequest;
                }
            }
            else
            {
                return HttpStatusCode.BadRequest;
            } 
                
            
        }

        public PartialViewResult EditAlbum(int albumId)
        {
            var albumViewModel = AlbumViewModel.GetAlbum(_context, albumId);
            return PartialView("_AddEditAlbum", albumViewModel);
        }

        [HttpPost]
        public HttpStatusCode EditAlbum(string title, string image, int id)
        {
            var album = _context.Albums.Where(a => a.Id == id).SingleOrDefault();


            try
            {
                album.Title = title;
                album.Image = String.IsNullOrEmpty(image) ? album.Image : image;
                _context.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }

        [HttpPost]
        public HttpStatusCode CreateAlbum(string title, string image)
        {
            var album = new Album
            {
                Title = title,
                Owner = User.Identity.Name.ToString(),
                Created = DateTime.Now,
                Image = image,
            };
            try
            {
                _context.Albums.Add(album);
                _context.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }

        [HttpPost]
        public HttpStatusCode DeleteAlbum(int Id)
        {
            var album = _context.Albums.Where(a => a.Id == Id).FirstOrDefault();
            try
            {
                _context.Albums.Attach(album);
                _context.Albums.Remove(album);
                _context.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }
    }
}

