

using CarService.App.Entities;

namespace CarService.App.Repositories
{
    public interface IRepository<T> : IWriteRepository<T>, IReadRepository<T>
        where T : class, ICar
    {
        void Remove(object carId);
    }
}
