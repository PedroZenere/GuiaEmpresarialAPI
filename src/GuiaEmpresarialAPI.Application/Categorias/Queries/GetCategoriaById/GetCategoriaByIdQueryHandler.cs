using AutoMapper;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Queries.GetCategoriaById
{
    public class GetCategoriaByIdQueryHandler : IRequestHandler<GetCategoriaByIdQuery, CategoriaViewModel>
    {
        private readonly IApplicationContext _appContext;
        private readonly IMapper _mapper;

        public GetCategoriaByIdQueryHandler(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }
        public async Task<CategoriaViewModel> Handle(GetCategoriaByIdQuery query, CancellationToken cancellationToken)
        {
            var queryable = await _appContext.Categorias.FirstOrDefaultAsync(x => x.Id == query.Id, cancellationToken);

            return _mapper.Map<CategoriaViewModel>(query);
        }
    }
}
