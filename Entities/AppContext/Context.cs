using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.AppContext
{
    public class Context: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Group> Groups { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:sql-server-kot.database.windows.net,1433;Initial Catalog=tfc-kingofthetower-db;Persist Security Info=False;User ID=admin-gallego;Password=@tfckot23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 60;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasIndex(p => p.NIF).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Mail).IsUnique();
        }
    }
}
