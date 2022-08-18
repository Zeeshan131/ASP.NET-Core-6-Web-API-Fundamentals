using CityInfo.API.Entities;
using CityInfo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<City>()
                .HasData(
                    new City("New Delhi") { Id = 1, Description = "The one with that big fort" },
                    new City("Mumbai") { Id = 2, Description = "The one which has lot of money" },
                    new City("Kolkata")
                    {
                        Id = 3,
                        Description = "The one which has a famous bridge",
                    }
                );
            modelBuilder
                .Entity<PointOfInterest>()
                .HasData(
                    new PointOfInterest("Red fort")
                    {
                        Id = 1,
                        CityId = 1,
                        Description =
                            "The most visited place in New Delhi. Built by Mughal emperor Shahjahan"
                    },
                    new PointOfInterest("Kutubminar")
                    {
                        Id = 2,
                        CityId = 1,
                        Description = "The minar built by Kutubuddin Ebak"
                    },
                    new PointOfInterest("Film Industries")
                    {
                        Id = 3,
                        CityId = 2,
                        Description = "The big cinema stars can be found here"
                    },
                    new PointOfInterest("Taj Hotel")
                    {
                        Id = 4,
                        CityId = 2,
                        Description = "One of India's wealthies hotel"
                    },
                    new PointOfInterest("Howrah bridge")
                    {
                        Id = 5,
                        CityId = 3,
                        Description = "The bridge is famous in india"
                    },
                    new PointOfInterest("Victoria Memorial")
                    {
                        Id = 6,
                        CityId = 3,
                        Description = "Large marvel building in central Kolkata"
                    }
                );
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("ConnectionString");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
