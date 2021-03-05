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