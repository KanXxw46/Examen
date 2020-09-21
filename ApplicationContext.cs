using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2._0
{
    class ApplicationContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Countre> Countres { get; set; }
        public ApplicationContext()
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb;Database = Examen2._0;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countre>()
                .ToTable("application_users")
                .HasKey(Countre => Countre.Id)
                .HasName("id");

            modelBuilder.Entity<Countre>()
                .Property(Countre => Countre.Name)
                .HasMaxLength(12)
                .IsRequired()
                .HasColumnName("name");

            modelBuilder.Entity<City>()
                .HasOne(Countre => Countre.Countre)
                .WithOne(city => city.City)
                .HasForeignKey("name");
            Countre countre = new Countre
            {
                Name = "Usa"
            };

            City city = new City
            {
                Name = "NewYork"
            };

            var CountreId = countre.Id;

            modelBuilder.Entity<Countre>()
                .HasData(countre);
        }
    }
}
