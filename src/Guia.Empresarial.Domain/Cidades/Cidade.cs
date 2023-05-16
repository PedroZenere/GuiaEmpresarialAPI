using Guia.Empresarial.Domain.Estados;

namespace Guia.Empresarial.Domain.Cidades
{
    public 
        class Cidade
    {
        public long Id { get; }
        public string Descricao { get; }
        public long EstadoId { get; }
        public Estado? Estado { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
