
using CarService.App.Data;
using CarService.App.Entities;
using CarService.App.Repositories;
using System.ComponentModel.Design;

var carRepository = new SqlRepository<Car>(new CarServiceDbContext());
AddHatchbacks(carRepository);
AddSUVs(carRepository);
WriteAllToConsole(carRepository);

static void AddHatchbacks(IRepository<Car> carRepository)
{
    carRepository.Add(new Car { CarName = "Audi A3" });
    carRepository.Add(new Car { CarName = "VW Passat B5" });
    carRepository.Add(new Car { CarName = "Fiat Bravo" });
    carRepository.Save();
}

static void AddSUVs(IWriteRepository<SUV> SUVRepository)
{
    SUVRepository.Add(new SUV { CarName = "BMW X1" });
    SUVRepository.Add(new SUV { CarName = "Audi Q5" });
    SUVRepository.Add(new SUV { CarName = "Mazda CX5" });
    SUVRepository.Save();
}

static void WriteAllToConsole(IReadRepository<ICar> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}
