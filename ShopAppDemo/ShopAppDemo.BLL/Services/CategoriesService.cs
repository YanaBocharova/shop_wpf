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
    public class CategoriesService : BaseService, ICategoriesService
    {
        public CategoriesService(IUnitOfWork uow) : base(uow)
        {
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<CategoryDTO> GetAllCategories()
        {
            
            var categories= db.CategoriesRepository.GetAll();
            return mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

       
        public CategoryDTO GetCategory(int id)
        {
            var cat = db.CategoriesRepository.Get(id);
            return mapper.Map<CategoryDTO>(cat);
        }
    }
}
