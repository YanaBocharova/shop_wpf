using ShopAppDemo.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.Interfaces
{
    public interface IProductsService:IDisposable
    {
        ProductDTO GetProduct(int id);
        IEnumerable<ProductDTO> GetAllProductsDTO();
        IEnumerable<ProductDTO> GetProductsDTOByCategory(string categoryName);
    }
}
