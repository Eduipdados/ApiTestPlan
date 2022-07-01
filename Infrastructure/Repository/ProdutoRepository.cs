using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Interfaces;
using Api.Domain.Models;
using Api.Infrastructure.Context;

namespace Api.Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DfDbContext _context;
        public ProdutoRepository(DfDbContext context)
        {
            _context = context;
        }
        public async Task<List<Produto>> BuscarProduto()
        {
            var query = await _context.Produtos.ToListAsync();

            return query;
        }

        
    }
}
