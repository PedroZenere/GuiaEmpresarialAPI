using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Shared.Core.Queries
{
    public abstract class GetByIdQueryBase<TViewModel> : IRequest<TViewModel>
    {
        public Guid Id { get; set; }
    }
}
