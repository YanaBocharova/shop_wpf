using AutoMapper;
using ShopAppDemo.BLL.DTO;
using ShopAppDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.AutoMapper
{
     public  class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();

            CreateMap<Account, AccountDTO>();
            CreateMap<AccountDTO, Account>();


            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

            CreateMap<BacketDTO, Backet>();
            CreateMap<Backet, BacketDTO>();

        }
    }
}
