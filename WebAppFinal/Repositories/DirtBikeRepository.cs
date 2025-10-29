using WebAppFinal.Models;

namespace WebAppFinal.Repositories 
{
    
    public class DirtBikeRepository : IDirtBikeRepository {
        private readonly DirtBikeContext _context;

        public DirtBikeRepository(DirtBikeContext context) {
            _context = context;
        }

        public IEnumerable<DirtBike> GetAll() => _context.DirtBikes.ToList();

        public DirtBike? GetById(int id) => _context.DirtBikes.Find(id);

        public void Add(DirtBike bike) {
            _context.DirtBikes.Add(bike);
        }

        public void Delete(int id) {
            var bike = _context.DirtBikes.Find(id);
            if (bike != null)
                _context.DirtBikes.Remove(bike);
        }

        public void Save() => _context.SaveChanges();
    }
}