using AutoMapper;
using GuiaEmpresarialAPI.Data.Context;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.Handlers
{
    public class RemoveCategoriaCommandHandler : IRequestHandler<RemoveCategoriaCommand, Unit>
    {
        protected readonly IApplicationContext _appContext;
        protected readonly IUnitOfWork _uow;
        protected readonly IMapper _mapper;

        public RemoveCategoriaCommandHandler(IApplicationContext appContext, IUnitOfWork uow, IMapper mapper)
        {
            _appContext = appContext;
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(RemoveCategoriaCommand request, CancellationToken cancellationToken)
        {
            var entity = await _appContext.Categorias.FirstOrDefaultAsync(x => x.Id == request.Id);
            var query = _appContext.Categorias.Remove(entity);

            await _uow.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
