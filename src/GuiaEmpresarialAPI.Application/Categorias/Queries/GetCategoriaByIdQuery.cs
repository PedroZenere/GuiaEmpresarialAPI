using AutoMapper;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Queries;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace GuiaEmpresarialAPI.Shared.Categorias.Queries
{
    public class GetCategoriaByIdQuery : GetByIdQueryBase<CategoriaViewModel>
    {
    }

    public class GetCategoriaByIdQueryHandler : IRequestHandler<GetCategoriaByIdQuery, CategoriaViewModel>
    {
        private readonly IApplicationContext _appContext;
        private readonly IMapper _mapper;

        public GetCategoriaByIdQueryHandler(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }
        public async Task<CategoriaViewModel> Handle(GetCategoriaByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await _appContext.Categorias.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            return _mapper.Map<CategoriaViewModel>(query);
        }
    }
}
