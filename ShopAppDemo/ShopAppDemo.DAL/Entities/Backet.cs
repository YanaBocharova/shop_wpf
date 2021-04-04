using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Entities
{
    public class Backet:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public Account Account { get; set; }


       
    }
}
