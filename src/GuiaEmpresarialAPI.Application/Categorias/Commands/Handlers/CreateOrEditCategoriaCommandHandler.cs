using AutoMapper;
using GuiaEmpresarialAPI.Data.Context;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Domain.Categorias.Entities;
using GuiaEmpresarialAPI.Shared.Categorias.Commands;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.Handlers
{
    public class CreateOrEditCategoriaCommandHandler : IRequestHandler<CreateOrEditCategoriaCommand, CategoriaViewModel>
    {
        protected readonly IApplicationContext _appContext;
        protected readonly IUnitOfWork _uow;
        protected readonly IMapper _mapper;

        public CreateOrEditCategoriaCommandHandler(IApplicationContext appContext, IUnitOfWork uow, IMapper mapper)
        {
            _appContext = appContext;
            _uow = uow;
            _mapper = mapper;
        }

        public async
            Task<CategoriaViewModel> Handle(CreateOrEditCategoriaCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Categoria>(request);

            var response = request.Id.HasValue ?
                _appContext.Categorias.Update(entity) : 
                await _appContext.Categorias.AddAsync(entity, cancellationToken);

            await _uow.SaveChangesAsync(cancellationToken);

            return _mapper.Map<CategoriaViewModel>(response.Entity);
        }
    }
}
