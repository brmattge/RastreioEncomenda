using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Mapeamentos
{
    public class EncomendasMap : EncomendasMapBase<Encomendas>
    {
        public override void Configure(EntityTypeBuilder<Encomendas> builder)
        {
            base.Configure(builder);
            builder.ToTable("Encomendas");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.IdPessoa).IsRequired().HasColumnName("IdPessoa");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome");
            builder.Property(c => c.Cep).IsRequired().HasColumnName("CEP");
            builder.Property(c => c.Logradouro).IsRequired().HasColumnName("Logradouro");
            builder.Property(c => c.Numero).IsRequired().HasColumnName("Numero");
            builder.Property(c => c.Complemento).IsRequired().HasColumnName("Complemento");
            builder.Property(c => c.Bairro).IsRequired().HasColumnName("Bairro");
            builder.Property(c => c.Cidade).IsRequired().HasColumnName("Cidade");
            builder.Property(c => c.Estado).IsRequired().HasColumnName("Estado");
            builder.Property(c => c.Status).IsRequired().HasColumnName("Status");

        }
    }
}
