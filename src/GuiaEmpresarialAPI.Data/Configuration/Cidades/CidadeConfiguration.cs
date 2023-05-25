using GuiaEmpresarialAPI.Domain.Cidades.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GuiaEmpresarialAPI.Data.Configuration.Cidades
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidades");

            builder.HasOne(x => x.Estados)
                   .WithMany(x => x.Cidades);
        }
    }
}
