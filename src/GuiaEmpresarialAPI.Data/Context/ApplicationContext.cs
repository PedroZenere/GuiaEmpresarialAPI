using GuiaEmpresarialAPI.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace GuiaEmpresarialAPI.Data.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        /// <summary>
        /// Definindo context
        /// </summary>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { 
        }
    }
}
