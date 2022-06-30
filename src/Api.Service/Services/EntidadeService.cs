using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using Domain.Entities;

namespace Api.Service.Services
{
    public class EntidadeService : IEntidadeService
    {
        private IRepository<Entidade> _repository;

        public EntidadeService(IRepository<Entidade> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Entidade> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<Entidade>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<Entidade> Post(Entidade entidade)
        {
            return await _repository.InsertAsync(entidade);
        }

        public async Task<Entidade> Put(Entidade entidade)
        {
            return await _repository.UpdateAsync(entidade);
        }
    }
}
