using DataAccess.Concrete;
using Entities.Concrete;


public class Program
{
    public static void Main(string[] args)
    {
        InMemoryCarDal inMemoryCar = new InMemoryCarDal();
        inMemoryCar.Add(new Car { Id = 7, ColorId = 5, BrandId = 2, ModelYear = "2021", DailyPrice = 350000, Description = "Skoda superb 2.0" });

        foreach (var car in inMemoryCar.GetAll())
        {
            Console.WriteLine(car.Description);
        }
        Console.WriteLine();
        Console.WriteLine("-------------");
        Console.WriteLine();

        CarManager carManager = new CarManager(new InMemoryCarDal());

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
    }
}