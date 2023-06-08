using GuiaEmpresarialAPI.Data.Context;
using GuiaEmpresarialAPI.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _appContext;
        public UnitOfWork(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<T> AddAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class
        {
            await _appContext.AddAsync(entity, cancellationToken);
            return entity;

        }
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _appContext.SaveChangesAsync(cancellationToken);
        }
    }
}
