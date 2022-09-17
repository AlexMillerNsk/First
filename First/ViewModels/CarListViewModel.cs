using First.data.Models;
using System.Collections.Generic;

namespace First.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }
    }
}
