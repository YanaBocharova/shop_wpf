using ShopAppDemo.DAL.EF;
using ShopAppDemo.DAL.Entities;
using ShopAppDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Repositories
{
    public class BacketsRepository : BaseRepository<Backet, int>
    {
        public BacketsRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<Backet> GetAll()
        {
            return table.Include(bac => bac.Account).ToList();
        }
        public override Backet Get(int id)
        {
            var item = table.Include(bac => bac.Account).FirstOrDefault(new Func<Backet, bool>(itm => (itm as BaseEntity<int>).Id.Equals(id)));
            if (item is null)
            {
                throw new NullReferenceException();
            }
            return item;
        }
        public override IEnumerable<Backet> GetAll(Func<Backet, bool> predicate)
        {
            
            return table.Include(bac=>bac.Account).Where(predicate).ToList();
        }
        public override void Update(Backet item)
        {
            throw new NotImplementedException();
        }
    }
}
