using AutoMapper;
using GuiaEmpresarialAPI.Application.Categorias.Commands.Services;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Domain.Categorias.Entities;
using GuiaEmpresarialAPI.Shared.Categorias.Commands;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.Handlers
{
    public class CreateOrEditCategoriaCommandHandler : IRequestHandler<CreateOrEditCategoriaCommand, CategoriaViewModel>
    {
        private readonly ICategoriaCommandServices services;

        public CreateOrEditCategoriaCommandHandler(ICategoriaCommandServices services)
        {
            this.services = services;
        }
        
        public async
            Task<CategoriaViewModel> Handle(CreateOrEditCategoriaCommand request, CancellationToken cancellationToken)
        {
            if (request.Id.HasValue)
                return await services.Atualizar(request, cancellationToken);

            return await services.Criar(request, cancellationToken);
        }
    }
}
