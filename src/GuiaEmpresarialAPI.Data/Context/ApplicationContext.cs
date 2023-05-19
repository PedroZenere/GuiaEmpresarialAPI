using GuiaEmpresarialAPI.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace GuiaEmpresarialAPI.Data.Context
{
    public partial class ApplicationContext : DbContext, IApplicationContext
    {
        /// <summary>
        /// Definindo context
        /// </summary>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}
