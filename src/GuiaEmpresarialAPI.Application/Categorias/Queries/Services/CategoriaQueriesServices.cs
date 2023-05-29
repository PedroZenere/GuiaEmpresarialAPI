using AutoMapper;
using Azure.Core;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.Queries;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Utils.PagedList;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Queries.Services
{
    public class CategoriaQueriesServices : ICategoriaQueriesServices
    {
        private readonly IApplicationContext _appContext;
        private readonly IMapper _mapper;

        public CategoriaQueriesServices(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }

        public async Task<IPaginatedList<CategoriaViewModel>> BuscaPorFiltro(GetCategoriaByFilterQuery query, CancellationToken cToken)
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

        public async Task<CategoriaViewModel> BuscarPorId(Guid Id, CancellationToken cToken)
        {
            var query = await _appContext.Categorias.FirstOrDefaultAsync(x => x.Id == Id, cToken);

            return _mapper.Map<CategoriaViewModel>(query);
        }
    }
}
