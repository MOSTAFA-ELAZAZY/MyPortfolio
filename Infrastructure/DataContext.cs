using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
   public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options )
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Owner>().HasData(new Owner
            {
                FullName = "Mostafa Elazazy",
                Avatar = "mostafa.jpg",
                Profil = ".Net Developer"

            });
        }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
    }
}
