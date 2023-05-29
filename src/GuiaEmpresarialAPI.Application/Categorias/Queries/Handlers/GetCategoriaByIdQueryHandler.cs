using AutoMapper;
using GuiaEmpresarialAPI.Application.Categorias.Queries.Services;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.Queries;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Queries.Handlers
{
    public class GetCategoriaByIdQueryHandler : IRequestHandler<GetCategoriaByIdQuery, CategoriaViewModel>
    {
        protected readonly ICategoriaQueriesServices services;

        public GetCategoriaByIdQueryHandler(ICategoriaQueriesServices services)
        {
            this.services = services;
        }
        public async Task<CategoriaViewModel> Handle(GetCategoriaByIdQuery request, CancellationToken cancellationToken)
        {
            return await services.BuscarPorId(request.Id, cancellationToken);
        }
    }
}
