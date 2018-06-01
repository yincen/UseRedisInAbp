using UsingRedisInAbp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace UsingRedisInAbp.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly UsingRedisInAbpDbContext _context;

        public InitialDataBuilder(UsingRedisInAbpDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
