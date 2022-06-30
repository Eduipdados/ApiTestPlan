using Api.Domain.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EntidadeMap : IEntityTypeConfiguration<Entidade>
    {
        public void Configure(EntityTypeBuilder<Entidade> builder)
        {
            builder.ToTable("Entidade");

            builder.HasKey(u => u.IdEntidade);

            builder.HasIndex(u => u.Id);

            builder.HasIndex(u => u.Nome)
                   .IsUnique();

            builder.Property(u => u.Cnpj)
                   .IsRequired()
                   .HasMaxLength(14);
        }
    }
}
