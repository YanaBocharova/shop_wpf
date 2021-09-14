using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Entities
{
    public class Product:BaseEntity<int> 
    {
        public string  Name { get; set; }
        public string  Image { get; set; }
        public decimal  Price { get; set; }
        public Category  Category { get; set; }
        public int?  CategoryId { get; set; }

        public void Copy(Product from)
        {
            Name = from.Name;
            Image = from.Image;
            Price = from.Price;
            //CategoryId = from.CategoryId;
        }
    }
}
