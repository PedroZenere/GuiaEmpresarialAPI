using AutoMapper;
using GuiaEmpresarialAPI.Domain.Categorias;
using GuiaEmpresarialAPI.Shared.Categorias.Commands;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;

namespace GuiaEmpresarialAPI.Application.Categorias.AutoMapperProfiles
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile() 
        {
            CreateMap<CreateOrEditCategoriaCommand, Categoria>();
            CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}
