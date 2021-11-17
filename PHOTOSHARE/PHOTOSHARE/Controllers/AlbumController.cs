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
    }
}
