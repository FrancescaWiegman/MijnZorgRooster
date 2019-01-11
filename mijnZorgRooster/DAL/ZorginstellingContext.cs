﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mijnZorgRooster.Models.Entities;

namespace mijnZorgRooster.DAL
{
    public class ZorginstellingContext : DbContext
    {
        public ZorginstellingContext(DbContextOptions<ZorginstellingDbContext> options) : base(options)
        {
        }

        public DbSet<Certificaat> Certificaten { get; set; }
        public DbSet<Contract> Contracten { get; set; }
        public DbSet<Medewerker> Medewerkers { get; set; }
        public DbSet<Rol> Rollen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certificaat>().ToTable("Certificaat");
            modelBuilder.Entity<Contract>().ToTable("Contract");
            modelBuilder.Entity<Medewerker>().ToTable("Medewerker");
            modelBuilder.Entity<Rol>().ToTable("Rol");
        }
    }
}
