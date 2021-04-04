using ShopAppDemo.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.Interfaces
{
    public interface ICategoriesService:IDisposable
    {
        CategoryDTO GetCategory(int id);
        IEnumerable<CategoryDTO> GetAllCategories();

    }
}
