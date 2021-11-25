using CarsAPI.Models;

namespace CarsAPI.DAL
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationContext dbContext) 
        {
            dbContext.Cars.AddRange(
                new List<Car>() 
                {
                    new Car()
                    {
                        Make = "Skoda",
                        Type = "Octavia",
                        IdentificationNumber = "123",
                        Year = 2010,
                        Capacity = 1600,
                        Mass = 1300,
                        Color = "White",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "Skoda",
                        Type = "Fabia",
                        IdentificationNumber = "124",
                        Year = 2011,
                        Capacity = 1200,
                        Mass = 1000,
                        Color = "Black",
                        NumberOfSeats = 4
                    },
                    new Car()
                    {
                        Make = "AUDI",
                        Type = "A3",
                        IdentificationNumber = "125",
                        Year = 2012,
                        Capacity = 2000,
                        Mass = 1280,
                        Color = "Red",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "AUDI",
                        Type = "A4",
                        IdentificationNumber = "126",
                        Year = 2013,
                        Capacity = 2400,
                        Mass = 1280,
                        Color = "Black",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "AUDI",
                        Type = "A6",
                        IdentificationNumber = "127",
                        Year = 2015,
                        Capacity = 2400,
                        Mass = 1250,
                        Color = "Blue",
                        NumberOfSeats = 5
                    },

                    new Car()
                    {
                        Make = "Hyundai",
                        Type = "Accent",
                        IdentificationNumber = "128",
                        Year = 2013,
                        Capacity = 1800,
                        Mass = 1240,
                        Color = "Green",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "Honda",
                        Type = "Accord",
                        IdentificationNumber = "129",
                        Year = 2012,
                        Capacity = 2000,
                        Mass = 1250,
                        Color = "White",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "Nissan",
                        Type = "Altima",
                        IdentificationNumber = "130",
                        Year = 2008,
                        Capacity = 1800,
                        Mass = 1200,
                        Color = "Blue",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "Nissan",
                        Type = "Armada",
                        IdentificationNumber = "131",
                        Year = 2014,
                        Capacity = 1900,
                        Mass = 1240,
                        Color = "Red",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "Subaru",
                        Type = "Ascent",
                        IdentificationNumber = "132",
                        Year = 2011,
                        Capacity = 2000,
                        Mass = 1250,
                        Color = "Blue",
                        NumberOfSeats = 5
                    },

                    new Car()
                    {
                        Make = "Toyota",
                        Type = "Avalon",
                        IdentificationNumber = "133",
                        Year = 2012,
                        Capacity = 1800,
                        Mass = 1300,
                        Color = "Black",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "Lincoln",
                        Type = "Aviator",
                        IdentificationNumber = "134",
                        Year = 2014,
                        Capacity = 3000,
                        Mass = 1300,
                        Color = "Yellow",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "Chevrolet",
                        Type = "Bolt EV",
                        IdentificationNumber = "135",
                        Year = 2020,
                        Capacity = 2000,
                        Mass = 1260,
                        Color = "Blue",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "Ford",
                        Type = "Bronco",
                        IdentificationNumber = "136",
                        Year = 2016,
                        Capacity = 1800,
                        Mass = 1200,
                        Color = "Black",
                        NumberOfSeats = 5
                    },
                    new Car()
                    {
                        Make = "Mercedes-Benz",
                        Type = "C-Class",
                        IdentificationNumber = "137",
                        Year = 2015,
                        Capacity = 2900,
                        Mass = 1300,
                        Color = "White",
                        NumberOfSeats = 5
                    }

                }
                );

            dbContext.Customers.AddRange(
                new List<Customer>() {
                    new Customer{
                        Id = 1,
                        Name = "Alex",
                        Email = "Alex@gmail.com",
                        Token = "Alex_"
                    },
                    new Customer{
                        Id = 2,
                        Name = "Vadim",
                        Email = "Vadim@gmail.com",
                        Token = "Vadim_"
                    }
                }
                );

            dbContext.SaveChanges();
        }
    }
}
