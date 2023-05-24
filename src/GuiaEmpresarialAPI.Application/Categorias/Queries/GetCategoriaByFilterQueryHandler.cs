using AutoMapper;
using Azure;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.Queries;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Utils.PagedList;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Queries
{
    public class GetCategoriaByFilterQueryHandler : IRequestHandler<GetCategoriaByFilterQuery, IPaginatedList<CategoriaViewModel>>
    {
        protected readonly IApplicationContext _appContext;
        protected readonly IMapper _mapper;
        public GetCategoriaByFilterQueryHandler(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }

        public async Task<IPaginatedList<CategoriaViewModel>> Handle(GetCategoriaByFilterQuery request, CancellationToken cancellationToken)
        {
            var query = _appContext.Categorias.AsQueryable();

            if(request.Nome != null)
            {
                query = query.Where(x => x.Nome == request.Nome);
            }

            if(request.CreatedAt.HasValue)
            {
                query = query.Where(x => x.CreatedAt == request.CreatedAt);
            }
            
            return _mapper.ProjectTo<CategoriaViewModel>(query).ToPaginatedList(request.Page, request.PageSize);
        }
    }
}
