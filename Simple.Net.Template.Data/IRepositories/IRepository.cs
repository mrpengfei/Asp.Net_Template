using Simple.Net.Template.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Novel.Core.Repository
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IRepository<TEntity,int> where TEntity : BaseEntity<int>
    {

    }

    public interface IRepository<TEntity,TKey>:IRepository where TEntity: BaseEntity<TKey>
    {
        Task<int> InsertAsync(TEntity entity);

        Task<bool> DeleteAsync(TEntity entity);

        Task<bool> UpdateAsync(TEntity entity);

        Task<TEntity> GetAsync(TKey key);

        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
