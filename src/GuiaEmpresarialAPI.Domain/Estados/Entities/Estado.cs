using GuiaEmpresarialAPI.Domain.Cidades.Entities;
using System.Collections.Generic;

namespace GuiaEmpresarialAPI.Domain.Estados.Entities
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public ICollection<Cidade>? Cidades { get; set; }
    }
}
