using GuiaEmpresarialAPI.Shared.Categorias.Queries;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Utils.PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Queries.Services
{
    public interface ICategoriaQueriesServices
    {
        public Task<CategoriaViewModel> BuscarPorId(Guid Id, CancellationToken cToken);
        public Task<IPaginatedList<CategoriaViewModel>> BuscaPorFiltro(GetCategoriaByFilterQuery query, CancellationToken cToken);
    }
}
