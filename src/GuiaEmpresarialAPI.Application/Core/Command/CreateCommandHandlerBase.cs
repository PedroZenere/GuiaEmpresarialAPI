using AutoMapper;
using Azure;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Domain.Core;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Core.Command
{
    public class CreateCommandHandlerBase<TCommand, TViewModel, TEntity> : IRequestHandler<TCommand, TViewModel>
        where TCommand : IRequest<TViewModel>
        where TEntity : EntityBase
    {
        protected readonly IApplicationContext _appContext;
        protected readonly IMapper _mapper;

        public CreateCommandHandlerBase(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }

        public async Task<TViewModel> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(request);

            var response = await _appContext.Set<TEntity>().AddAsync(entity);

            return _mapper.Map<TViewModel>(response);
        }
    }
}
