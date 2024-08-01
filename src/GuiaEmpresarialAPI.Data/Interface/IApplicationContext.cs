using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Data.Interface
{
    public partial interface IApplicationContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
