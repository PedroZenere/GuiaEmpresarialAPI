using MediatR;
using System;

namespace GuiaEmpresarialAPI.Application.Core.Commands
{
    public class RemoveCommandBase : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
