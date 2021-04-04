using ShopAppDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.Model
{
    public class ProductModel: BaseViewModel
    {
        public int Id { get; set; }

        private string name;

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

        private string image;
        public string Image
        {
            get => image;
            set
            {
                if (!value.Equals(image))
                {
                    image = value;
                    OnPropertyChanged(nameof(Image));
                }
            }
        }
        public decimal Price { get; set; }
        public CategoryModel Category { get; set; }
        public int? CategoryId { get; set; }

    }
}
