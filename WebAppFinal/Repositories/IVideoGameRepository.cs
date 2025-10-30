using WebAppFinal.Models;

namespace WebAppFinal.Repositories
{
    public interface IVideoGameRepository
    {
        IEnumerable<VideoGame> GetAll();
        VideoGame? GetById(int id);
        void Add(VideoGame VideoGame);
        void Delete(int id);
        void Save();
    }
}
