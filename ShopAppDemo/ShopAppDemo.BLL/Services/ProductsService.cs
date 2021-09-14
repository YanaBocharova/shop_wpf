using ShopAppDemo.BLL.DTO;
using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.Services
{
    public class ProductsService : BaseService, IProductsService
    {
        public ProductsService(IUnitOfWork uow) : base(uow)
        {
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<ProductDTO> GetAllProductsDTO()
        {
            //var products = db.ProductsRepository.GetAll();
            
            var products = db.ProductsRepository.GetAll(prod=>prod.CategoryId<4);
            return mapper.Map<IEnumerable<ProductDTO>>(products);
        }


        public ProductDTO GetProduct(int id)
        {
            var prod = db.ProductsRepository.Get(id);
            return mapper.Map<ProductDTO>(prod);
        }

        public IEnumerable<ProductDTO> GetProductsDTOByCategory(string categoryName)
        {
            var products = db.ProductsRepository.GetAll(prod => prod.Category.Name == categoryName ); ;
            return mapper.Map<IEnumerable<ProductDTO>>(products);
        }
    }
}
