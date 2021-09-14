using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.AutoMapper
{
    public class Mapper
    {
        private static Mapper _instance;
        private IMapper _mapper;
        public static Mapper Instance => _instance ?? (_instance = new Mapper());
        public IMapper AutoMapper => _mapper;
        private Mapper()
        {
            var mapConfig = new MapperConfiguration(cnfg =>
            {
                cnfg.AddProfile(new MappingProfile());
            });
            _mapper = mapConfig.CreateMapper();
        }
        public TDestination Map<TDestination>(object sourse)
        {
            return _mapper.Map<TDestination>(sourse);
        }
    }
}
