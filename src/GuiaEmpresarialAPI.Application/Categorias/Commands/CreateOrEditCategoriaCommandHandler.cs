using AutoMapper;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Domain.Categorias;
using GuiaEmpresarialAPI.Shared.Categorias.Commands;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands
{
    public class CreateOrEditCategoriaCommandHandler : IRequestHandler<CreateOrEditCategoriaCommand, CategoriaViewModel>
    {
        protected readonly IApplicationContext _appContext;
        protected readonly IMapper _mapper;

        public CreateOrEditCategoriaCommandHandler(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }
        public async 
            Task<CategoriaViewModel> Handle(CreateOrEditCategoriaCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Categoria>(request);

            var response = !request.Id.HasValue ? await _appContext.Categorias.AddAsync(entity, cancellationToken) : _appContext.Categorias.Update(entity);
            await _appContext.SaveChangesAsync(cancellationToken);
            return _mapper.Map<CategoriaViewModel>(response.Entity);
        }
    }
}
