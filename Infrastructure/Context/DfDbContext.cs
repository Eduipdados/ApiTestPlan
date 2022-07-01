using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api.Domain.Models;
using Api.Infrastructure.Configurations;

namespace Api.Infrastructure.Context
{
    public class DfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
       

        public DfDbContext() : base()
        {
        }
        public DfDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DfDbContext).Assembly);

            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
           
        }
    }
}
