using GuiaEmpresarialAPI.Data.Context;
using GuiaEmpresarialAPI.Data.Interface;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationContext _appContext;
        public UnitOfWork(IApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _appContext.SaveChangesAsync(cancellationToken);
        }
    }
}
