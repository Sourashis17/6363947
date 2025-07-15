using Microsoft.EntityFrameworkCore;
using _1_Web_API_handson.Models;
using System;
using System.Collections.Generic;

namespace _1_Web_API_handson.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
