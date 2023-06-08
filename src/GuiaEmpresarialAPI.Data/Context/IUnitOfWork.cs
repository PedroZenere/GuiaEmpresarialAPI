using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
