using PTC.DOTIC.EntityFrameworkCore;

namespace PTC.DOTIC.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly DOTICDbContext _context;

        public InitialHostDbBuilder(DOTICDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
