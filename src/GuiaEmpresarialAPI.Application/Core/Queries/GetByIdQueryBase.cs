using MediatR;
using System;

namespace GuiaEmpresarialAPI.Application.Core.Queries
{
    public abstract class GetByIdQueryBase<TViewModel> : IRequest<TViewModel>
    {
        public Guid Id { get; set; }
    }
}
