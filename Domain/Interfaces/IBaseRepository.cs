using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces
{
    public interface IBaseRepository<TModel> : IDisposable where TModel : class
    {
        Task Criar(TModel model);
        Task Criar(IEnumerable<TModel> model);
        Task<int> SaveChanges();
        Task Alterar(TModel model);

    }
}
