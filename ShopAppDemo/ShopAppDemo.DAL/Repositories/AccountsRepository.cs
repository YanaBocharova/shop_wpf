using ShopAppDemo.DAL.EF;
using ShopAppDemo.DAL.Entities;
using ShopAppDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Repositories
{
    public class AccountsRepository : BaseRepository<Account, int>
    {
        public AccountsRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<Account> GetAll()
        {
            return table.Include(acc=>acc.SelectedProducts).ToList();
        }
        public override IEnumerable<Account> GetAll(Func<Account, bool> predicate)
        {
            return table.Include(prod => prod.SelectedProducts).Where(predicate).ToList();
        }
        public override void Update(Account item)
        {
            var srch = Get(item.Id);
            srch.Copy(item);
            context.SaveChanges();
        }
    }
}
