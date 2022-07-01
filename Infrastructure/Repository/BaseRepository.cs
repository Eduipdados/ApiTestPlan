using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Interfaces;
using Api.Infrastructure.Context;

namespace Api.Infrastructure.Repository
{
    public abstract class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : class, new()
    {
        protected readonly DfDbContext Db;
        protected readonly DbSet<TModel> DbSet;

        protected BaseRepository(DfDbContext context)
        {
            Db = context;
            DbSet = Db.Set<TModel>();
        }

        public virtual async Task Criar(TModel model)
        {

            DbSet.Add(model);
            await SaveChanges();

        }

        public virtual async Task Alterar(TModel model)
        {
            DbSet.Update(model);
            await SaveChanges();
        }


        public virtual async Task Criar(IEnumerable<TModel> models)
        {
            foreach (var model in models)
            {
                DbSet.Add(model);
            }

            await SaveChanges();

        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
