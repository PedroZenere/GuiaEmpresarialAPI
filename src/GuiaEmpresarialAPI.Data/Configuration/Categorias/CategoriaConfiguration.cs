﻿using GuiaEmpresarialAPI.Domain.Categorias.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GuiaEmpresarialAPI.Data.Configuration.Categorias
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            
        }
    }
}
