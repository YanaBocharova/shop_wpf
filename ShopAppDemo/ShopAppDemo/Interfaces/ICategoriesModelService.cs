using ShopAppDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.Interfaces
{
    public interface ICategoriesModelService
    {
        CategoryModel GetCategory(int id);
        IEnumerable<CategoryModel> GetAllCategories();
    }
}
