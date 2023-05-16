using Guia.Empresarial.Domain.Cidades;
using System.Collections.Generic;
using System.Linq;

namespace Guia.Empresarial.Domain.Estados
{
    public class Estado
    {
        public long Id { get; }
        public string Descricao { get; }
        public string Sigla { get; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public readonly List<Cidade> _cidades;
        public IReadOnlyCollection<Cidade> Cidades => _cidades.ToList();
    }
}
