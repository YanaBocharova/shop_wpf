using ShopAppDemo.BLL.DTO;
using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.DAL.Entities;
using ShopAppDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.Services
{
    public class BacketsService : BaseService, IBacketsService
    {
        public BacketsService(IUnitOfWork uow) : base(uow)
        {
        }

        public void AddProduct(AccountDTO acc, ProductDTO prod)
        {
            BacketDTO backetDTO = new BacketDTO
            {
                Name = prod.Name,
                Price=prod.Price,
                Image=prod.Image,
                Account = acc,
            };
            var b = mapper.Map<Backet>(backetDTO);
            db.BacketsRepository.Create(b);
            db.Save();
               
        }

        public IEnumerable<BacketDTO> GetAllByAccount(AccountDTO acc)
        {

            var backets = db.BacketsRepository.GetAll(b => b.Account.Login == acc.Login);
            return mapper.Map<IEnumerable<BacketDTO>>(backets);
        }
    }
}
