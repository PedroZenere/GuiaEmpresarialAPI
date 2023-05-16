using Guia.Empresarial.Domain.Anuncios;
using Guia.Empresarial.Domain.Core;
using Guia.Empresarial.Domain.Empresas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.Empresarial.Domain.Anuncio
{
    class Anuncio : BaseEntity
    {
        public virtual Empresa Empresa { get; set; }
        public Guid EmpresaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
