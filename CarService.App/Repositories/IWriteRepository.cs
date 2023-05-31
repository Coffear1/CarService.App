
using CarService.App.Entities;

namespace CarService.App.Repositories
{
    public interface IWriteRepository<in T> where T : class, ICar
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}
