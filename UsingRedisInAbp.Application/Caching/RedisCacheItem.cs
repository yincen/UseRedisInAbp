using System;

namespace UsingRedisInAbp.Caching
{
    public class RedisCacheItem
    {
        public Type Type { get; set; }
        public string Item { get; set; }
    }
}