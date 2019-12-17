using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//этот класс хранит настройки бд
namespace Shop.Data
{
    public class AppDBContent : DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)// : base () передает options в базовый конструктор
        {

        }
        //подключение к бд происходит через файл dbsettings.json
        public DbSet<Car> Car { get; set; }//получает или устанавливает все товары
        public DbSet<Category> Category { get; set; }//получает или устанавливает все категории
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


    }
}
