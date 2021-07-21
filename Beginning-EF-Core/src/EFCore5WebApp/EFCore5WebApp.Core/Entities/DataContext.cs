using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore5WebApp.Core.Entities
{
     
    class DataContext : DbContext
    {
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<Cube> Cube { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shape>()
            .HasDiscriminator<string>("ShapeType")
            .HasValue<Shape>("S")
            .HasValue<Cube>("C");

            //modelBuilder.Entity<Shape>().ToTable("Shape");
            //modelBuilder.Entity<Cube>().ToTable("Cube");

        }


    }

}
