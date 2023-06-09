﻿using CarRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRelation.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Brand>Brands { get; set; }
       public DbSet<Model>Models { get; set; }
    }
}
