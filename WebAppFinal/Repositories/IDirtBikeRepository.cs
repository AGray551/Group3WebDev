using WebAppFinal.Models;

public interface IDirtBikeRepository
{
    IEnumerable<DirtBike> GetAll();
    DirtBike? GetById(int id);
    void Add(DirtBike bike);
    void Delete(int id);
    void Save();
}