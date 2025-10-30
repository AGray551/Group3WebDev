using WebAppFinal.Models;

namespace WebAppFinal.Repositories
{
    public interface IDistanceRunningRepository
    {
        IEnumerable<DistanceRunning> GetAll();
        DistanceRunning? GetById(int id);
        void Add(DistanceRunning distanceRunning);
        void Delete(int id);
        void Save();
    }
}
