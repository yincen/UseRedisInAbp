using Abp.Application.Services;
using Abp.Application.Services.Dto;
using UsingRedisInAbp.Caching.Dto;

namespace UsingRedisInAbp.Caching
{
    public interface ICacheTestAppService : IApplicationService
    {
        ArticleDto GetArticle(IdInput input);
        ArticleDto CreateArticle(ArticleDto input);
    }
}