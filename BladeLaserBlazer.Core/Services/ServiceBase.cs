using BladeLaserBlazer.Core.Data;

namespace BladeLaserBlazer.Core.Services
{
    public abstract class ServiceBase
    {
        protected BLBDbContext _context;

        public ServiceBase(BLBDbContext context)
        {
            _context = context;
        }
    }
}
