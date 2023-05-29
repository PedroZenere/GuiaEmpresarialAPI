using GuiaEmpresarialAPI.Shared.Categorias.Commands;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.Services
{
    public interface ICategoriaCommandServices
    {
        public Task<CategoriaViewModel> Criar(CreateOrEditCategoriaCommand command, CancellationToken cToken);
        public Task<CategoriaViewModel> Atualizar(CreateOrEditCategoriaCommand command, CancellationToken cToken);
        public Task<Unit> Deletar(Guid Id, CancellationToken cToken);
    }
}
