using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Shared.Core.Commands
{
    public class RemoveCommandBase : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
