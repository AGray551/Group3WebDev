using WebAppFinal.Models;

namespace WebAppFinal.Repositories
{
    public class DistanceRunningRepository : IDistanceRunningRepository
    {
        private readonly ApplicationDbContext _context;

        public DistanceRunningRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DistanceRunning> GetAll() => _context.DistanceRunnings.ToList();

        public DistanceRunning? GetById(int id) => _context.DistanceRunnings.Find(id);

        public void Add(DistanceRunning distanceRunning)
        {
            _context.DistanceRunnings.Add(distanceRunning);
        }

        public void Delete(int id)
        {
            var distanceRunning = _context.DistanceRunnings.Find(id);
            if (distanceRunning != null)
                _context.DistanceRunnings.Remove(distanceRunning);
        }

        public void Save() => _context.SaveChanges();
    }
}
