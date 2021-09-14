using ShopAppDemo.BLL.AutoMapper;
using ShopAppDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.Interfaces
{
    public abstract class BaseService
    {
        protected IUnitOfWork db;
        protected Mapper mapper;
        public BaseService(IUnitOfWork uow)
        {
            db = uow;
            mapper = Mapper.Instance;
        }
    }
}
