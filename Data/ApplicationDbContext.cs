using InternetShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternetShop4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Item> items { get; set; }
        public DbSet<Category> categories { get; set; }

        public DbSet<Brand> brands { get; set; }

        public DbSet<Comment> comments { get; set; }
    }
}
