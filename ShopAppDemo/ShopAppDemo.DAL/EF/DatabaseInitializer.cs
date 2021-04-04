using ShopAppDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.EF
{
    public class DatabaseInitializer: CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            base.Seed(context);

            //  added category
            var category1 = new Category { Name = "Women" };
            var category2 = new Category { Name = "Men" };
            var category3 = new Category { Name = "Kids" };

            var prod1 = new Product
            {
                Name = "Sneakers 1",
                Image = "/Images/кросы.jpg",
                Category = category1,
                Price = 3000
            };
            var prod2 = new Product
            {
                Name = "Sneakers 2",
                Image = "/Images/puma.jpg",
                Category = category1,
                Price = 1500
            };

            var prod3 = new Product
            {
                Name = "Sneakers 3",
                Image = "/Images/крос.jpeg",
                Category = category2,
                Price = 2500
            };

            var prod4 = new Product
            {
                Name = "Sneakers 4",
                Image = "/Images/white.jpg",
                Category = category2,
                Price = 1000
            };

            var prod5 = new Product
            {
                Name = "Sneakers 5",
                Image = "/Images/pink.jpg",
                Category = category3,
                Price = 1200
            };

            context.Products.AddRange(new Product[] { prod1, prod2, prod3,prod4,prod5 });
            context.SaveChanges();
            
        }
    }
}
