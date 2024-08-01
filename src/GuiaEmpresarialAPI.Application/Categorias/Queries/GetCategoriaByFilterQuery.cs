using AutoMapper;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Queries;
using GuiaEmpresarialAPI.Shared.Core.Utils.PagedList;
using MediatR;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace GuiaEmpresarialAPI.Shared.Categorias.Queries
{
    public class GetCategoriaByFilterQuery : GetByFilterQueryBase, IRequest<IPaginatedList<CategoriaViewModel>>
    {
        public string? Nome { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
    }

    public class GetCategoriaByFilterQueryHandler : IRequestHandler<GetCategoriaByFilterQuery, IPaginatedList<CategoriaViewModel>>
    {
        private readonly IApplicationContext _appContext;
        private readonly IMapper _mapper;
        public GetCategoriaByFilterQueryHandler(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }

        public async Task<IPaginatedList<CategoriaViewModel>> Handle(GetCategoriaByFilterQuery request, CancellationToken cancellationToken)
        {
            var query = _appContext.Categorias.AsQueryable();

            if (request.Nome != null)
            {
                query = query.Where(x => x.Nome == request.Nome);
            }

            if (request.CreatedAt.HasValue)
            {
                query = query.Where(x => x.CreatedAt == request.CreatedAt);
            }

            return await _mapper.ProjectTo<CategoriaViewModel>(query).ToPagedListAsync(request.Page, request.PageSize);
        }
    }
}
