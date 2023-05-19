using GuiaEmpresarialAPI.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Domain.Empresas
{
    public class Empresa : EntityBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

    }
}
