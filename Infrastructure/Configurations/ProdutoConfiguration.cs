using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Api.Domain.Models;

namespace Api.Infrastructure.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder
                .ToTable(name: "Produtos", schema: "SRV");

            builder
                 .HasKey(conf => conf.IdProduto);

            builder
                .Property(conf => conf.Nome)
                .HasColumnName("Nome");

            builder
                .Property(conf => conf.GrupoQuimico)
                .HasColumnName("GrupoQuimico");

            builder
                .Property(conf => conf.PrincipioAtivo)
                .HasColumnName("PrincipioAtivo");

            builder
              .Property(conf => conf.Concentracao)
              .HasColumnName("Concentracao");

            builder
            .Property(conf => conf.RegistroSaude)
            .HasColumnName("RegistroSaude");

        }
    }
}
