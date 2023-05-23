using System;

namespace GuiaEmpresarialAPI.Shared.Core.Commands
{
    public abstract class CreateOrEditCommandBase
    {
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
