using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingRedisInAbp.Articles;

namespace UsingRedisInAbp.Caching.CachingSync
{
    public class ArticleChangedHandler : EntityChangedHandlerBase<Article>
    {
        
    }
}
