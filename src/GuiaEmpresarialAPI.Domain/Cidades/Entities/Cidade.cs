using GuiaEmpresarialAPI.Domain.Estados.Entities;

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
