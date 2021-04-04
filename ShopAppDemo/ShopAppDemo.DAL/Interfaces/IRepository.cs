using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Interfaces
{
    public interface IRepository<TValue,TKey>
        where TValue:class
        where TKey: struct
    {
        TValue Get(TKey id);
        IEnumerable<TValue> GetAll();
        IEnumerable<TValue> GetAll(Func<TValue,bool> predicate);

        void Create(TValue item);
        void Remove(TKey item);
        void Update(TValue item);


    }
}
