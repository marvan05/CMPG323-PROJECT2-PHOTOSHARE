﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PHOTOSHARE.Areas.Identity.Data;
using PHOTOSHARE.Models;

namespace PHOTOSHARE.Data
{
    public class PHOTOSHAREDBContext : IdentityDbContext<PHOTOSHAREUser>
    {
        public PHOTOSHAREDBContext(DbContextOptions<PHOTOSHAREDBContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<SharedAlbum> SharedAlbum { get; set; }
        public DbSet<Photo> Photo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Album>().ToTable("album");
            builder.Entity<SharedAlbum>().ToTable("SharedAlbums");
            builder.Entity<Photo>().ToTable("Photos");
        }
    }
}
