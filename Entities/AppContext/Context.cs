using Entities.Common;
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
            optionsBuilder.UseSqlServer(Connections.StringConnection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasIndex(p => p.NIF).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Mail).IsUnique();
        }
    }
}
