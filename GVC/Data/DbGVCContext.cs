using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GVC.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GVC.Data
{
    public class DbGVCContext:DbContext
    {
        public DbGVCContext(DbContextOptions<DbGVCContext> options) : base(options)
        {
        }

        public DbSet<OddEvents> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=DbGVC;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<OddEvents>()
                .HasKey(k => k.EventId);

            

        }

    }
}
