using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using UsingRedisInAbp.Articles;
using UsingRedisInAbp.Caching.Dto;
using UsingRedisInAbp.Users;

namespace UsingRedisInAbp.Caching
{
    public class CacheTestAppService :AbpServiceBase, ICacheTestAppService
    {
       private readonly IRepository<Article> _repository;
       public ICacheService CacheService { get; set; }

       public CacheTestAppService(IRepository<Article> repository)
       {
           _repository = repository;
       }

       public ArticleDto GetArticle(IdInput input)
       {
           return CacheService.GetCachedEntity<Article>(input.Id).MapTo<ArticleDto>();
       }

       public ArticleDto CreateArticle(ArticleDto input)
       {
           var entity = input.MapTo<Article>();
           var id= _repository.InsertAndGetId(entity);
           entity.Id = id;

           return entity.MapTo<ArticleDto>();
       }
    }
}
