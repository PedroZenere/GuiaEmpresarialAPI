using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.Empresarial.Data.Configuration
{
    internal class DatabaseConfiguration
    {
        /// <summary>
        /// Configuration para acessar as infos do appSettings
        /// </summary>
        /// <param name="configuration"></param>
        public static void ConfigureDatabase(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("ConexaoBanco");
        }
    }
}
