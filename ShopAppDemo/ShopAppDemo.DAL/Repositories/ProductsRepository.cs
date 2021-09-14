using ShopAppDemo.DAL.EF;
using ShopAppDemo.DAL.Entities;
using ShopAppDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ShopAppDemo.DAL.Repositories
{
    public class ProductsRepository : BaseRepository<Product, int>
    {
        public ProductsRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<Product> GetAll()
        {
            return table.Include(prod=>prod.Category).ToList();
        }
        public override Product Get(int id)
        {
            var item = table.Include(pr=>pr.Category).FirstOrDefault(new Func<Product, bool>(itm => (itm as BaseEntity<int>).Id.Equals(id)));
            if (item is null)
            {
                throw new NullReferenceException();
            }
            return item;
        }
        public override IEnumerable<Product> GetAll(Func<Product, bool> predicate)
        {
            return table.Include(prod => prod.Category).Where(predicate).ToList();
        }
        public override void Update(Product item)
        {
            var srch = Get(item.Id);
            srch.Copy(item);
            context.SaveChanges();
        }
    }
}
