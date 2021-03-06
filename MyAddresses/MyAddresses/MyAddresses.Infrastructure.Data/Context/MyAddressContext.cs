using Microsoft.EntityFrameworkCore;
using MyAddresses.Domain.Models;
using MyAddresses.Infrastructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Infrastructure.Data.Context
{
    public class MyAddressContext : DbContext
    {
        private const string LocalConn = "Server=(localdb)\\MSSQLLocalDB;Database=MyAddressesDb;Trusted_Connection=True;";

        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Settlement> Settlements { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Binding> Bindings { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(LocalConn);
        }
    }
}