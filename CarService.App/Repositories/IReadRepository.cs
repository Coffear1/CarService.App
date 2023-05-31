

using CarService.App.Entities;

namespace CarService.App.Repositories
{
    public interface IReadRepository<out T> where T : class, ICar
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
