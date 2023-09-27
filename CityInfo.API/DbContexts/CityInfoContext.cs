using CityInfo.API.Entities;
using CityInfo.API.Models;
using Microsoft.EntityFrameworkCore;
namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City("New York City")
                {
                    Id = 1,
                    Description = "The one with the big park."
                },
                new City("Antwerp")
                {
                    Id = 2,
                    Description = "The one with the catedral."
                },
                new City("Paris")
                {
                    Id = 3,
                    Description = "The one with the big tower."
                });
            modelBuilder.Entity<PointOfInterest>().HasData(
                 new PointOfInterest("Central Park")
                 {
                     Id = 1,
                     CityId = 1,
                     Description = "The most visited urban park in USA."
                 },
                 new PointOfInterest("Empire State Building")
                 {
                     Id = 2,
                     CityId = 1,
                     Description = "Big."
                 },
                 new PointOfInterest("Catedral Of Our Lady")
                 {
                     Id = 3,
                     CityId = 2,
                     Description = "Gothic style"
                 },
                  new PointOfInterest("Antwerp Central Station")
                  {
                      Id = 4,
                      CityId = 2,
                      Description = "Railway in Belguin"
                  },
                  new PointOfInterest("Eiffel Tower")
                  {
                      Id = 5,
                      CityId = 3,
                      Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel."
                  },
                  new PointOfInterest("The Louvre")
                  {
                      Id = 6,
                      CityId = 3,
                      Description = "The world's largest museum."
                  }
                );
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
