using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Events.Bus.Entities;
using Abp.Events.Bus.Handlers;
using Abp.RedisCache.Configuration;
using NMemory.Linq;
using Shouldly;
using UsingRedisInAbp.Articles;
using UsingRedisInAbp.Caching;
using UsingRedisInAbp.Caching.CachingSync;
using Xunit;

namespace UsingRedisInAbp.Tests.CachingSync
{
    public class CacheSync_Tests : UsingRedisInAbpTestBase
    {
         [Fact]
        public void Test_Entity_Changed_Event()
        {
             LoginAsHostAdmin();
             var title = "unit_test";
             var articleId = 0;
             var service = Resolve<TestCacheSyncService>();
             service.IsCreatedEventFired.ShouldBeFalse();
             service.IsUpdatedEventFired.ShouldBeFalse();
             service.IsDeletedEventFired.ShouldBeFalse();
             
             //新增文章测试
             UsingDbContext(c =>c.Articles.Add(new Article {Title = title}));
             
             service.IsCreatedEventFired.ShouldBe(true);

             //更新文章测试
             UsingDbContext(c =>
             {
                 var article=c.Articles.First();
                 c.Articles.Attach(article);
                 article.Title = "new_title";
             });
             service.IsUpdatedEventFired.ShouldBe(true);

             //删除文章测试
             UsingDbContext(c =>
             {
                 var article = c.Articles.First();
                 c.Articles.Remove(article);                 
             });
             service.IsDeletedEventFired.ShouldBe(true);
        }
    }

    public class TestCacheSyncService : ICacheSyncService
    {
        public bool IsCreatedEventFired { get; set; }
        public bool IsDeletedEventFired { get; set; }
        public bool IsUpdatedEventFired { get; set; }
        public void Add<TEntity>(TEntity entity) where TEntity : class, IEntity<int>
        {
            IsCreatedEventFired = true;
            
        }

        public void Remove<TEntity>(int id) where TEntity : class, IEntity<int>
        {
            IsDeletedEventFired = true;

        }

        public void Update<TEntity>(TEntity entity) where TEntity : class, IEntity<int>
        {
            IsUpdatedEventFired = true;
        }
    }    
}
