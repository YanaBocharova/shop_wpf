using ShopAppDemo.DAL.EF;
using ShopAppDemo.DAL.Entities;
using ShopAppDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Repositories
{
    public class CategoriesRepository : BaseRepository<Category, int>
    {
        public CategoriesRepository(ShopContext context) : base(context)
        {
        }

        public override void Update(Category item)
        {
            var srch = Get(item.Id);
            srch.Copy(item);
            context.SaveChanges();
        }
    }
}
