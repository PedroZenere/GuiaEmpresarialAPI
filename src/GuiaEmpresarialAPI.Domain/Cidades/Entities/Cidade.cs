using GuiaEmpresarialAPI.Domain.Estados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Domain.Cidades.Entities
{
    public class Cidade
    {
        public long Id { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado? Estados { get; set; }
        public string Nome { get; set; }
    }
}
