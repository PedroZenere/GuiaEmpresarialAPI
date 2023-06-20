using System;

namespace GuiaEmpresarialAPI.Application.Core.Commands
{
    public abstract class CreateOrEditCommandBase
    {
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
