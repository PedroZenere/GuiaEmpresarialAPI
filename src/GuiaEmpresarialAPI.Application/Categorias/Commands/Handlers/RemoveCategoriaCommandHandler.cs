using GuiaEmpresarialAPI.Application.Categorias.Commands.Services;
using GuiaEmpresarialAPI.Shared.Categorias.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.Handlers
{
    public class RemoveCategoriaCommandHandler : IRequestHandler<RemoveCategoriaCommand, Unit>
    {
        public readonly ICategoriaCommandServices services;

        public RemoveCategoriaCommandHandler(ICategoriaCommandServices services)
        {
            this.services = services;
        }

        public async Task<Unit> Handle(RemoveCategoriaCommand request, CancellationToken cancellationToken)
        {
            return await services.Deletar(request.Id, cancellationToken);
        }
    }
}
