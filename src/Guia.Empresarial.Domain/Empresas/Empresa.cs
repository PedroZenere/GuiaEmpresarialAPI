using Guia.Empresarial.Domain.Core;
using Guia.Empresarial.Domain.Enderecos;
using System.Collections.Generic;
using System.Linq;

namespace Guia.Empresarial.Domain.Empresas
{
    public class Empresa : BaseEntity
    {
        public string NomeEmpresa { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }

        public readonly List<Endereco> _enderecos;
        public IReadOnlyCollection<Endereco> Enderecos => _enderecos.ToList();
    }
}
