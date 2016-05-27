using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
using System.Web;
//Johan Thörner
namespace JohanThorner_MVC_2016_05.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreDatabase")
        {
            Database.SetInitializer<StoreContext>(new StoreContextInitializer());
        }
        public DbSet<Store> Stores { get; set; } 
        public DbSet<Product> Products { get; set; } 
    }

    public class StoreContextInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            List<Store> stores = new List<Store>()
            {
                new Store() {Address = "Strandvägen 1", Name = "Kalles Livs", StoreId = 1},
                new Store() {Address = "Badhusgatna 1", Name = "Pelles Livs", StoreId = 2}
            };
            foreach (var store in stores)
            {
                context.Stores.Add(store);
            }
            context.SaveChanges();
            List<Product> products = new List<Product>()
            {
                new Product() {Name = "Kaffe", Price = 45,ProductId = 1, ProductNumber = "p-12345", ProductText = "Ett smarrigt kaffe",ProductsInStock = 45},
                new Product() {Name = "Bönor", Price = 45,ProductId = 2, ProductNumber = "p-12345", ProductText = "Goda bönor",ProductsInStock = 2},
                new Product() {Name = "Smör", Price = 45,ProductId = 3, ProductNumber = "p-12345", ProductText = "Gott smör",ProductsInStock = 2},
                new Product() {Name = "juice", Price = 45,ProductId = 4, ProductNumber = "p-12345", ProductText = "God juice",ProductsInStock = 2},
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}