using ShopAppDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.Model
{
    public class CategoryModel: BaseViewModel
    {
        public int Id { get; set; }
        private string name = string.Empty;

        public string Name
        {
            get => name;
            set
            {
                if (!value.Equals(name))
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public List<ProductModel> Products { get; set; }
    }
}
