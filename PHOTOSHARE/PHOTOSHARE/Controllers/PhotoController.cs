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
    public class PhotoController : Controller
    {

        private readonly PHOTOSHAREDBContext _context;

        public PhotoController(PHOTOSHAREDBContext context)
        {
            _context = context;
        }

        public IActionResult Index(int albumId)
        {
            var vm = new PhotoViewModel(_context, albumId);
            return View(vm);
        }

        public PartialViewResult CreatePhoto()
        {
            var PhotoViewModel = new PhotoViewModel();
            return PartialView("_AddEditPhoto", PhotoViewModel);
        }

        public PartialViewResult EditPhoto(int PhotoId)
        {
            var vm = PhotoViewModel.GetPhoto(_context, PhotoId);
            return PartialView("_AddEditPhoto", vm);
        }

        [HttpPost]
        public HttpStatusCode EditPhoto(string title, string image, int id)
        {
            var Photo = _context.Photo.Where(a => a.Id == id).SingleOrDefault();


            try
            {
                Photo.Title = title;
                Photo.Image = String.IsNullOrEmpty(image) ? Photo.Image : image;
                _context.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }

        [HttpPost]
        public HttpStatusCode CreatePhoto(string title, int albumId, string image)
        {
            var Photo = new Photo
            {
                Title = title,
                AlbumId = albumId,
                Image = image,
                Created = DateTime.Now
            };
            try
            {
                _context.Photo.Add(Photo);
                _context.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                return HttpStatusCode.BadRequest;
            }
        }

        [HttpPost]
        public HttpStatusCode DeletePhoto(int Id)
        {
            var Photo = _context.Photo.Where(a => a.Id == Id).FirstOrDefault();
            try
            {
                _context.Photo.Attach(Photo);
                _context.Photo.Remove(Photo);
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
