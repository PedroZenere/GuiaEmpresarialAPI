using GuiaEmpresarialAPI.Domain.Categorias.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuiaEmpresarialAPI.Data.Interface
{
    public partial interface IApplicationContext
    {
        DbSet<Categoria> Categorias { get; set; }
    }
}
