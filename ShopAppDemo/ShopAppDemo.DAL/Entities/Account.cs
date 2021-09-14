using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Entities
{
    public class Account: BaseEntity<int>
    {
        public string  Login { get; set; }
        public string  Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //1 ко многоим
        public ICollection<Product> SelectedProducts { get; set; }
        public void Copy(Account from)
        {
            Login = from.Login;
            Password = from.Password;
            Email = Email;
            Phone = Phone;
            SelectedProducts = from.SelectedProducts;
        }
    }
}
