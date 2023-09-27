using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        //public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "Big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Park"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Big"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Cathedral",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Catedral Of Our Lady",
                            Description = "Gothic style"
                        },
                        new PointOfInterestDto()
                        {
                            Id= 4,
                            Name = "Antwerp Central Station",
                            Description = "Railway in Belguin"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Eiffel Tower",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                         new PointOfInterestDto()
                         {
                             Id = 5,
                             Name = "Eiffel Tower",
                             Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel."
                         },
                         new PointOfInterestDto()
                          {
                             Id = 6,
                             Name = "The Louvre",
                             Description = "The world's largest museum."
                          }
                    }
                }
            };
        }
    }
}
