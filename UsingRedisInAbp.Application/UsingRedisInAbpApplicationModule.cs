using System.Reflection;
using Abp;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.RedisCache;
using Abp.Runtime.Caching;
using UsingRedisInAbp.Caching;

namespace UsingRedisInAbp
{
    [DependsOn(typeof(UsingRedisInAbpCoreModule), typeof(AbpAutoMapperModule))]
    public class UsingRedisInAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {           
            base.PreInitialize();
            //IocManager.Register<ICache,RedisCache>();
            IocManager.Register<ICacheManager, RedisCacheManager>();            
            //如果Redis在本机,并且使用的默认端口,下面的代码可以不要
            //Configuration.Modules.AbpRedisCacheModule().ConnectionStringKey = "KeyName";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
