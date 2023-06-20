using AutoMapper;
using GuiaEmpresarialAPI.Data.Context;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Domain.Categorias.Entities;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.CreateCategoria
{
    public class CreateCategoriaCommandHandler : IRequestHandler<CreateCategoriaCommand, CategoriaViewModel>
    {
        protected readonly IApplicationContext _appContext;
        protected readonly IUnitOfWork _uow;
        protected readonly IMapper _mapper;

        public CreateCategoriaCommandHandler(IApplicationContext appContext, IUnitOfWork uow, IMapper mapper)
        {
            _appContext = appContext;
            _uow = uow;
            _mapper = mapper;
        }

        public async
            Task<CategoriaViewModel> Handle(CreateCategoriaCommand command, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Categoria>(command);

            var response = await _appContext.Categorias.AddAsync(entity, cancellationToken);
            await _uow.SaveChangesAsync(cancellationToken);

            return _mapper.Map<CategoriaViewModel>(response.Entity);
        }
    }
}
