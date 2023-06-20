using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Application.Core.Queries;
using GuiaEmpresarialAPI.Shared.Core.Utils.PagedList;
using MediatR;
using System;

namespace GuiaEmpresarialAPI.Application.Categorias.Queries.GetCategoriaByFilter
{
    public class GetCategoriaByFilterQuery : GetByFilterQueryBase, IRequest<IPaginatedList<CategoriaViewModel>>
    {
        public string Nome { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
    }
}
