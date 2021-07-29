using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Mapeamentos
{
    public class LocalidadesMap : LocalidadesMapBase<Localidades>
    {
        public override void Configure(EntityTypeBuilder<Localidades> builder)
        {
            base.Configure(builder);
            builder.ToTable("Localidades");
            builder.Property(c => c.Cep).IsRequired().HasColumnName("CEP");
            builder.Property(c => c.Logradouro).IsRequired().HasColumnName("Logradouro");
            builder.Property(c => c.Bairro).IsRequired().HasColumnName("Bairro");
            builder.Property(c => c.Cidade).IsRequired().HasColumnName("Cidade");
            builder.Property(c => c.Estado).IsRequired().HasColumnName("Estado");
        }
    }
}
