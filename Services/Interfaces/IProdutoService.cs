using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Application.ViewModels;
using Api.Application.ViewModels.Produto;
using Api.Domain.Models;

namespace Api.Services.Interfaces
{
    public interface IProdutoService
    {
        Task<List<ProdutoViewModel>> BuscarProduto();
       
    }
}