using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Mapeamentos
{
    public class PessoasMap : PessoasMapBase<Pessoas>
    {
        public override void Configure(EntityTypeBuilder<Pessoas> builder)
        {
            base.Configure(builder);
            builder.ToTable("Pessoas");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome");
            builder.Property(c => c.Cpf).IsRequired().HasColumnName("CPF");
        }
    }
}
