using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Application.Core.Commands;
using MediatR;
using System;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.CreateCategoria
{
    public class CreateCategoriaCommand : CreateOrEditCommandBase, IRequest<CategoriaViewModel>
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
    }
}
