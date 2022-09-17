using First.data.Models;
using System.Collections.Generic;

namespace First.data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable <Car> Cars { get;  }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carID);
    }
}
