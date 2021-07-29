using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Mapeamentos
{
    public class LocalidadesMapBase<T> : IEntityTypeConfiguration<T>
        where T : LocalidadesEntidadeBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Cep);

            builder.Property(c => c.Cep).IsRequired().HasColumnName("Cep");
        }
    }
}
