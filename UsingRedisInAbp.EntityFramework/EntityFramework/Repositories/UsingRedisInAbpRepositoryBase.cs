using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace UsingRedisInAbp.EntityFramework.Repositories
{
    public abstract class UsingRedisInAbpRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<UsingRedisInAbpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected UsingRedisInAbpRepositoryBase(IDbContextProvider<UsingRedisInAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class UsingRedisInAbpRepositoryBase<TEntity> : UsingRedisInAbpRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected UsingRedisInAbpRepositoryBase(IDbContextProvider<UsingRedisInAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
