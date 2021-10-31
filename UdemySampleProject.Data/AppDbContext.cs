using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UdemySampleProject.Core.Models;
using UdemySampleProject.Data.Configuration;
using UdemySampleProject.Data.Seeds;

namespace UdemySampleProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categpries { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int[] categoryIdArray = new int[] { 1, 2 };
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSeed(categoryIdArray));
            modelBuilder.ApplyConfiguration(new CategorySeed(categoryIdArray));
        }
    }
}
