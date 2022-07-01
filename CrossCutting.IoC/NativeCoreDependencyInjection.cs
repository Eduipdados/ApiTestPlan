using Api.Domain.Interfaces;
using Api.Infrastructure.Context;
using Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using Api.Infrastructure.Repository;
using Api.Services.Services;

namespace Api.CrossCutting.IoC
{
    public static class NativeCoreDependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            #region Repositorioes
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            #endregion

            #region Services
            services.AddScoped<IProdutoService, ProdutoService>();
            #endregion

            var connectionStrings = configuration.GetConnectionString("Connection");

            services.AddDbContext<DfDbContext>(options =>
                options.UseSqlServer(connectionStrings));
        }
    }
}
