using AutoMapper;
using Azure;
using GuiaEmpresarialAPI.Application.Categorias.Queries.Services;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.Queries;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Utils.PagedList;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Queries.Handlers
{
    public class GetCategoriaByFilterQueryHandler : IRequestHandler<GetCategoriaByFilterQuery, IPaginatedList<CategoriaViewModel>>
    {
        protected readonly ICategoriaQueriesServices services;
        public GetCategoriaByFilterQueryHandler(ICategoriaQueriesServices services)
        {
            this.services= services;
        }

        public async Task<IPaginatedList<CategoriaViewModel>> Handle(GetCategoriaByFilterQuery request, CancellationToken cancellationToken)
        {
            return await services.BuscaPorFiltro(request, cancellationToken);
        }
    }
}
