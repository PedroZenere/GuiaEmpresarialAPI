using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Data.Context
{
    public interface IUnitOfWork
    {
        Task<T> AddAsync<T>(T entity, CancellationToken cancellation) where T : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
