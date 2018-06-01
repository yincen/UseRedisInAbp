using System.Data.Entity.Migrations;
using UsingRedisInAbp.Migrations.SeedData;

namespace UsingRedisInAbp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<UsingRedisInAbp.EntityFramework.UsingRedisInAbpDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "UsingRedisInAbp";
        }

        protected override void Seed(UsingRedisInAbp.EntityFramework.UsingRedisInAbpDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
