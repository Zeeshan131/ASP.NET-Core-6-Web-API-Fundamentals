using CityInfo.API.Models;

namespace CityInfo.API;

public class CitiesDataStore
{
    public List<CityDto> Cities { get; set; }

    //public static CitiesDataStore Current { get; } = new CitiesDataStore();

    public CitiesDataStore()
    {
        // init dummy data
        Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id = 1,
                Name = "New Delhi",
                Description = "The one with that big fort",
                PointsOfInterest = new List<PointOfInterestDto>
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "It has red fort",
                        Description =
                            "The most visited place in New Delhi. Built by Mughal emperor Shahjahan"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 2,
                        Name = "Kutubminar",
                        Description = "The minar built by Kutubuddin Ebak"
                    }
                }
            },
            new CityDto()
            {
                Id = 2,
                Name = "Mumbai",
                Description = "The one which has lot of money",
                PointsOfInterest = new List<PointOfInterestDto>
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "Film Industries",
                        Description = "The big cinema starts can be found here"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 2,
                        Name = "Taj Hotel",
                        Description = "One of India's wealthies hotel"
                    }
                }
            },
            new CityDto()
            {
                Id = 3,
                Name = "Kolkata",
                Description = "The one which has a famous bridge",
                PointsOfInterest = new List<PointOfInterestDto>
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "Howrah bridge",
                        Description = "The bridge is famous in india"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 2,
                        Name = "Victoria Memorial",
                        Description = "Large marvel building in central Kolkata"
                    }
                }
            },
        };
    }
}
