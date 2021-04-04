using ShopAppDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.EF
{
    public class ShopContext:DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Backet> Backets{ get; set; }

        static ShopContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        public ShopContext(string connectionString):base(connectionString)
        {

        }
    }
}
