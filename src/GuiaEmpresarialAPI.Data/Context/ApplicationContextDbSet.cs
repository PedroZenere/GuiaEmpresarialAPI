using GuiaEmpresarialAPI.Domain.Categorias.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuiaEmpresarialAPI.Data.Context
{
    public partial class ApplicationContext
    {
        public virtual DbSet<Categoria> Categorias { get; set; }
    }
}
