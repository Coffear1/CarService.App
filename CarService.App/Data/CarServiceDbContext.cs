

using CarService.App.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarService.App.Data
{
    public class CarServiceDbContext : DbContext 
    {
        public DbSet<Car> Cars => Set<Car>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("CarServiceInMemory");
        }
    }
}
