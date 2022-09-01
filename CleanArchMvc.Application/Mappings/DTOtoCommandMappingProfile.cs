using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Products.Commands;

namespace CleanArchMvc.Application.Mappings
{
    public  class DTOtoCommandMappingProfile : Profile
    {
        public DTOtoCommandMappingProfile()
        {
            CreateMap<ProductCreateCommand, ProductDTO>().ReverseMap();
            CreateMap<ProductUpdateCommand, ProductDTO>().ReverseMap();
        }
    }
}
