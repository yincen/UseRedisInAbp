using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using UsingRedisInAbp.Articles;
using UsingRedisInAbp.Authorization.Roles;
using UsingRedisInAbp.MultiTenancy;
using UsingRedisInAbp.Users;

namespace UsingRedisInAbp.EntityFramework
{
    public class UsingRedisInAbpDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        public IDbSet<Article> Articles { get; set; } 

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public UsingRedisInAbpDbContext()
            : base("Default")
        {
            //Configuration.ProxyCreationEnabled = false;
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in UsingRedisInAbpDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of UsingRedisInAbpDbContext since ABP automatically handles it.
         */
        public UsingRedisInAbpDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            //Configuration.ProxyCreationEnabled = false;
        }

        //This constructor is used in tests
        public UsingRedisInAbpDbContext(DbConnection connection)
            : base(connection, true)
        {
            //Configuration.ProxyCreationEnabled = false;
        }
    }
}
