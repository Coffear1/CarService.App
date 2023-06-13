
using CarService.App.Data;
using CarService.App.Entities;
using CarService.App.Repositories;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

bool ExitApp = false;
Console.WriteLine("--Witam w aplikacji serwisowej służącej do zapisu samochodów odwiedzających serwis--");
Console.WriteLine();
var carRepository = new FileRepository<Car>();

//carRepository.ItemAdded += CarAdded;
//carRepository.ItemRemoved += CarRemoved;

while(!ExitApp)
{
    Console.WriteLine("-----Wybierz co chcesz zrobić poniżej wpisując odpowiedni numer akcji-----");
    Console.WriteLine();
    Console.WriteLine("1 ------- aby odczytać wszystkie samochody na serwisie");
    Console.WriteLine("2 ------- aby dodać samochód na serwis");
    Console.WriteLine("3 ------- aby usunąć samochód z serwisu");
    var input = Console.ReadLine();

    switch(input)
    {
        case "1":
            Console.WriteLine("Odczytuję wszystkie samochody w serwisie");
            {
                WriteAllToConsole(carRepository);
            }
            break;
        case "2":
            Console.WriteLine("Dodaj samochód do listy serwisowej");
            {
                AddCar(carRepository); 
                break;
            }
        case "3":
            Console.WriteLine("Usuń samochód z listy serwisowej");
            {
                RemoveCar(carRepository);
                break;
            }
        default: Console.WriteLine("wybierz numer akcji");
            break;
    }
}

void RemoveCar(IRepository<Car> carRepository)
{
    var CarId = FindCarById(carRepository);
    if(CarId != null)
    {
        carRepository.Remove(CarId);
    }
}

object FindCarById(IRepository<Car> carRepository)
{
    throw new NotImplementedException();
}

void AddCar(IRepository<Car> carRepository)
{
    var newCar = new Car();
    carRepository.Add(newCar);   
}

static void WriteAllToConsole<T>(IReadRepository<T> repository) where T : class, ICar, new()
{
    var cars = repository.GetAll();
    if (cars.ToList().Count == 0)
    {
        Console.WriteLine("Nie znaleziono samochodów");
    }
    else if (cars.ToList().Count > 0)
    {
        Console.WriteLine(cars);
    }

}