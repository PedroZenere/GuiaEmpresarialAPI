using GuiaEmpresarialAPI.Data.Context;
using GuiaEmpresarialAPI.Data.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.RemoveCategoria
{
    public class RemoveCategoriaCommandHandler : IRequestHandler<RemoveCategoriaCommand, Unit>
    {
        protected readonly IApplicationContext _appContext;
        protected readonly IUnitOfWork _uow;
        public RemoveCategoriaCommandHandler(IApplicationContext appContext, IUnitOfWork uow)
        {
            _appContext = appContext;
            _uow = uow;
        }

        public async Task<Unit> Handle(RemoveCategoriaCommand command, CancellationToken cancellationToken)
        {
            var entity = await _appContext.Categorias.FirstOrDefaultAsync(x => x.Id == command.Id);
            var query = _appContext.Categorias.Remove(entity);

            await _uow.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
