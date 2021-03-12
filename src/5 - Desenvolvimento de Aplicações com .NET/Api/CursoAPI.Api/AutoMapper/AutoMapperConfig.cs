using AutoMapper;
using CursoAPI.Api.ViewModels;
using CursoMVC.Business.Models;

namespace CursoAPI.Api.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Categoria, CategoriaViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
