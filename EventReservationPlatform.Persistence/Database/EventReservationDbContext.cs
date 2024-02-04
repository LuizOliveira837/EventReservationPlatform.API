using EventReservationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Persistence.Database
{
    public class EventReservationDbContext : DbContext
    {

        public EventReservationDbContext(DbContextOptions<EventReservationDbContext> options) :
            base(options)
        {

        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Location> Locations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Definir chave primeria

            modelBuilder.Entity<Room>()
                        .ToTable("Rooms")
                      .HasKey(r => r.Id);

            modelBuilder.Entity<Location>()
                    .ToTable("Locations")
                    .HasKey(l => l.Id);

            modelBuilder.Entity<Room>()
                    .HasOne(r => r.Location)
                    .WithMany()
                    .HasForeignKey(lo => lo.LocationId)
                    .OnDelete(DeleteBehavior.Cascade);

        }
        

    }
}
