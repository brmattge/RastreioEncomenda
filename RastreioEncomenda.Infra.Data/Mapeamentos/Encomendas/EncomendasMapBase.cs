using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RastreioEncomenda.Dominio.Entidades;

namespace RastreioEncomenda.Infra.Data.Mapeamentos
{
    public class EncomendasMapBase<T> : IEntityTypeConfiguration<T>
        where T : EncomendasEntidadeBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.IdPessoa).HasColumnName("IdPessoa");
        }
    }
}
