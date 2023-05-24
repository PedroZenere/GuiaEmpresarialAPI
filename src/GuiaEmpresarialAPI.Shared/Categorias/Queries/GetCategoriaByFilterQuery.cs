using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Queries;
using GuiaEmpresarialAPI.Shared.Core.Utils.PagedList;
using MediatR;
using System;

namespace GuiaEmpresarialAPI.Shared.Categorias.Queries
{
    public class GetCategoriaByFilterQuery : GetByFilterQueryBase, IRequest<IPaginatedList<CategoriaViewModel>>
    {
        public string? Nome { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
    }
}
