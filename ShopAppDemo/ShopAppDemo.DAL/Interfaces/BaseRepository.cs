using ShopAppDemo.DAL.EF;
using ShopAppDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Interfaces
{
    public abstract class BaseRepository<TValue, TKey> 
        : IRepository<TValue, TKey>
        where TKey : struct
        where TValue : class
    {
        protected ShopContext context;
        protected DbSet<TValue> table;
        public BaseRepository(ShopContext context)
        {
            this.context = context;
            table = context.Set<TValue>();
        }
        public virtual void Create(TValue item)
        {
            table.Add(item);
            context.SaveChanges();
        }

        public virtual TValue Get(TKey id)
        {
            var item = table.FirstOrDefault(new Func<TValue, bool>(itm => (itm as BaseEntity<int>).Id.Equals(id)));
            if (item is null)
            {
                throw new NullReferenceException();
            }
            return item;
        }
        public virtual IEnumerable<TValue> GetAll()
        {
            return table.ToList();

        }

        public virtual IEnumerable<TValue> GetAll(Func<TValue, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public virtual void Remove(TKey id)
        {
            var item = Get(id);
            table.Remove(item);
            context.SaveChanges();
        }

        public abstract void Update(TValue item);
    }
}
