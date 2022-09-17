using First.data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
namespace First.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Category.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "cool",
                        longDesc = "",
                        img = "/img/mclaren.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford",
                        shortDesc = "nice",
                        longDesc = "",
                        img = "/img/mercedes_benz.jpg",
                        price = 5000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
            );
            }


            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                        new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" },
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;    
            }
        }
    }
}
