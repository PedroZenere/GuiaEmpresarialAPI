using Guia.Empresarial.Domain.Cidades;
using Guia.Empresarial.Domain.Core;
using System;

namespace Guia.Empresarial.Domain.Enderecos
{
    public class Endereco : BaseEntity
    {
        public string Logradoro { get; set;}
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public virtual Cidade Cidade { get; set; }
        public Guid CidadeId { get; set; }
    }
}
