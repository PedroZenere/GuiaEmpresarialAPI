using AutoMapper;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Utils.PagedList;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Queries.GetCategoriaByFilter
{
    public class GetCategoriaByFilterQueryHandler : IRequestHandler<GetCategoriaByFilterQuery, IPaginatedList<CategoriaViewModel>>
    {
        private readonly IApplicationContext _appContext;
        private readonly IMapper _mapper;
        public GetCategoriaByFilterQueryHandler(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }

        public async Task<IPaginatedList<CategoriaViewModel>> Handle(GetCategoriaByFilterQuery query, CancellationToken cancellationToken)
        {
            var queryable = _appContext.Categorias.AsQueryable();

            if (query.Nome != null)
            {
                queryable = queryable.Where(x => x.Nome == query.Nome);
            }

            if (query.CreatedAt.HasValue)
            {
                queryable = queryable.Where(x => x.CreatedAt == query.CreatedAt);
            }
            return await _mapper.ProjectTo<CategoriaViewModel>(queryable).ToPagedListAsync(query.Page, query.PageSize);
        }
    }
}
