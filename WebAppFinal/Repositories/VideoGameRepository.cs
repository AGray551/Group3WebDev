using WebAppFinal.Models;

namespace WebAppFinal.Repositories
{
    public class VideoGameRepository : IVideoGameRepository
    {
        private readonly ApplicationDbContext _context;

        public VideoGameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<VideoGame> GetAll() => _context.VideoGames.ToList();

        public VideoGame? GetById(int id) => _context.VideoGames.Find(id);

        public void Add(VideoGame VideoGame)
        {
            _context.VideoGames.Add(VideoGame);
        }

        public void Delete(int id)
        {
            var VideoGame = _context.VideoGames.Find(id);
            if (VideoGame != null)
                _context.VideoGames.Remove(VideoGame);
        }

        public void Save() => _context.SaveChanges();
    }
}
