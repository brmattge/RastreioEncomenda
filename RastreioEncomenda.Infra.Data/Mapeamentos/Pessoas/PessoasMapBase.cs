using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Mapeamentos
{
    public class PessoasMapBase<T> : IEntityTypeConfiguration<T>
        where T : PessoasEntidadeBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
        }
    }
}
