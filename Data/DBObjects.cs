using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {

        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any()) content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                        new Car { name = "Tesla Model S", shortDesc = "Быстрый автомобиль", longDesc = "Красивый, быстрый и очень тихий автомобиль", img = "", price = 45000, isFavorite = true, available = true, Category = Categories["Электромобили"] },
                        new Car { name = "Ford Fiesta", shortDesc = "Тихий и спокойный", longDesc = "Удобный автомобиль для городской жизни", img = "", price = 11000, isFavorite = false, available = true, Category = Categories["Классические автомобили"] },
                        new Car { name = "BMW M3", shortDesc = "Дерзкий и стильный", longDesc = "", img = "Удобный автомобиль для городской жизни", price = 65000, isFavorite = false, available = true, Category = Categories["Классические автомобили"] },
                        new Car { name = "Mercedes C class", shortDesc = "Уютный и большой", longDesc = "Удобный автомобиль для городской жизни", img = "", price = 40000, isFavorite = false, available = false, Category = Categories["Классические автомобили"] },
                        new Car { name = "Nissan Leaf", shortDesc = "Бесшумный и экономный", longDesc = "Удобный автомобиль для городской жизни", img = "", price = 14000, isFavorite = true, available = true, Category = Categories["Электромобили"] }
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
                        new Category{categoryName = "Электромобили",desc = "Современный вид транспорта"},
                        new Category{categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list) category.Add(el.categoryName, el);
                }
                return category;
            }
        }

    }
}
