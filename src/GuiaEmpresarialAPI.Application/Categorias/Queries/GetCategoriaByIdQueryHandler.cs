using AutoMapper;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.Queries;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Queries
{
    public class GetCategoriaByIdQueryHandler : IRequestHandler<GetCategoriaByIdQuery, CategoriaViewModel>
    {
        protected readonly IApplicationContext _appContext;
        protected readonly IMapper _mapper;

        public GetCategoriaByIdQueryHandler(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper= mapper;
        }
        public async Task<CategoriaViewModel> Handle(GetCategoriaByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await _appContext.Categorias.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            return _mapper.Map<CategoriaViewModel>(query);
        }
    }
}
