using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Commands;
using MediatR;
using System;

namespace GuiaEmpresarialAPI.Shared.Categorias.Commands
{
    public class CreateOrEditCategoriaCommand : CreateOrEditCommandBase, IRequest<CategoriaViewModel>
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
    }
}
