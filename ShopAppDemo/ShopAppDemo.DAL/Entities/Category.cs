using System.Collections.Generic;

namespace ShopAppDemo.DAL.Entities
{
    public class Category:BaseEntity<int>
    {
        public string  Name { get; set; }
        public ICollection<Product> Products { get; set; }

        public void Copy(Category from)
        {
            Name = from.Name;
        }
    }
}