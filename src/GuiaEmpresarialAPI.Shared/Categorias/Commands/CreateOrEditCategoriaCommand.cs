using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using System;

namespace GuiaEmpresarialAPI.Shared.Categorias.Commands
{
    public class CreateOrEditCategoriaCommand : IRequest<CategoriaViewModel>
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
    }
}
