using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Runtime.Caching;
using Abp.Zero.EntityFramework;
using UsingRedisInAbp.EntityFramework;

namespace UsingRedisInAbp
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(UsingRedisInAbpCoreModule))]
    public class UsingRedisInAbpDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";            
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
