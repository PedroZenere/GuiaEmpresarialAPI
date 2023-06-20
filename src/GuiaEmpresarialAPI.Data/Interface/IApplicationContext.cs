using Microsoft.EntityFrameworkCore;

namespace GuiaEmpresarialAPI.Data.Interface
{
    public partial interface IApplicationContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
