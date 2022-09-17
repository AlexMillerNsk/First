using First.data.Interfaces;
using First.data.Models;
using System.Collections.Generic;
using System.Linq;

namespace First.data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {

                    new Car { 
                        name = "Tesla", 
                        shortDesc = "cool", 
                        longDesc = "", 
                        img = "/img/mclaren.jpeg", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Ford",
                        shortDesc = "nice",
                        longDesc = "",
                        img = "/img/mercedes_benz.jpg",
                        price = 5000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carID)
        {
            throw new System.NotImplementedException();
        }
    }
}
