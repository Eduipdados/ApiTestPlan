using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Domain.Entities;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IEntidadeService
    {
        Task<Entidade> Get(Guid id);
        Task<IEnumerable<Entidade>> GetAll();
        Task<Entidade> Post(Entidade entidade);
        Task<Entidade> Put(Entidade entidade);
        Task<bool> Delete(Guid id);
    }
}
