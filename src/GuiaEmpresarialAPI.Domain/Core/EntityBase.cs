using System;

namespace GuiaEmpresarialAPI.Domain.Core
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
