using Dapper.Contrib.Extensions;
using Novel.Core.Repository;
using Simple.Net.Template.Data.Entities;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Novel.Core.Dapper.Repository
{
    public class DapperRepository : IRepository
    {
        protected readonly ISessionManager session;

        public DapperRepository(ISessionManager session)
        {
            this.session = session;
        }

        protected virtual IDbConnection GetDbConnection()
        {
            return session.GetConnection();
        }
    }

    public abstract class DapperRepository<TEntity> : DapperRepository<TEntity, int>, IRepository<TEntity, int> where TEntity : BaseEntity<int>
    {
        public DapperRepository(ISessionManager session) : base(session)
        {
        }
    }

    public abstract class DapperRepository<TEntity, TKey> : DapperRepository, IRepository<TEntity, TKey> where TEntity: BaseEntity<TKey>
    {
        public DapperRepository(ISessionManager session) : base(session)
        {
        }

        public Task<bool> DeleteAsync(TEntity entity)
        {
            return this.GetDbConnection().DeleteAsync(entity, session.Transaction);
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return this.GetDbConnection().GetAllAsync<TEntity>(session.Transaction);
        }

        public Task<TEntity> GetAsync(TKey key)
        {
            return this.GetDbConnection().GetAsync<TEntity>(key, session.Transaction);
        }

        public Task<int> InsertAsync(TEntity entity)
        {
            return this.GetDbConnection().InsertAsync(entity, session.Transaction);
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            return this.GetDbConnection().UpdateAsync(entity, session.Transaction);
        }
    }
}
