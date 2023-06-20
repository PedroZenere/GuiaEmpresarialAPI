using AutoMapper;
using GuiaEmpresarialAPI.Domain.Categorias.Entities;
using GuiaEmpresarialAPI.Application.Categorias.Commands.CreateCategoria;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;

namespace GuiaEmpresarialAPI.Application.Categorias.AutoMapperProfiles
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile() 
        {
            CreateMap<CreateCategoriaCommand, Categoria>();
            CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}
