using AutoMapper;
using IMobile.Entities.Concrete;
using IMobile.Entities.DTO_s.ProductDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Business.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<ProductCreateDto, Product>();
        }
    }
}
