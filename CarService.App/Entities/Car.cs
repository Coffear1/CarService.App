

namespace CarService.App.Entities;
public class Car : CarBase
{
    public string? CarName { get; set; }
    public override string ToString() => $"Id: {Id}, CarName: {CarName}";
}
 