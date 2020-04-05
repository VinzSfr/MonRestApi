using Microsoft.EntityFrameworkCore;
using MonRestApi.Infrastructure.Data.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonRestApi.Infrastructure.Data
{
    public class TicketDbContext : DbContext
    {
        public DbSet<Ticket> Ticket { get; set; }

        public TicketDbContext(DbContextOptions<TicketDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ticket>()
                        .HasOne(t => t.Utilisateur)
                        .WithMany(u => u.Ticket);
        }

    }
}
