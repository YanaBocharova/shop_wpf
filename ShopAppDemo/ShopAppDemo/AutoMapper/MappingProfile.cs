using AutoMapper;
using ShopAppDemo.BLL.DTO;
using ShopAppDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.Services.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductModel, ProductDTO>();
            CreateMap<ProductDTO, ProductModel>();

            CreateMap<AccountModel, AccountDTO>();
            CreateMap<AccountDTO, AccountModel>();

            CreateMap<CategoryModel, CategoryDTO>();
            CreateMap<CategoryDTO, CategoryModel>();

            CreateMap<BacketModel, BacketDTO>();
            CreateMap<BacketDTO, BacketModel>();

        }
    }
}
