using First.data.Interfaces;
using First.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    public class CarsController : Controller   {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat) {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        
        }
        public ViewResult List() {

            CarListViewModel obj = new CarListViewModel();
            ViewBag.Title = "Cars CArsCCCARS";
            obj.allCars = _allCars.Cars;
            obj.currCategory = "AvtomoBILLzz";
            return View(obj);
        
        } 
    }
}
