using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Models;

namespace Api.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> BuscarProduto();
    }
}
