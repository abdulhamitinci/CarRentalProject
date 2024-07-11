using Business.Concrete;
using Business.Constans;
using DataAccess.Concrete;
using Entities.Concrete;

using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Reflection.Metadata.Ecma335;
using Umbraco.Core.Models.Membership;
using EfCarDal = DataAccess.Concrete.EntityFramework.EfCarDal;

using Microsoft.Identity.Client;


public class Program
{
    public static void Main(string[] args)
    {

        CarManager carManager = new CarManager(new EfCarDal());

        //--------Messages denemesi yapıldı.------------

        var result = carManager.GetCarDetails();

        if (result.Success)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + " / " + car.ColorName + " / " + car.BrandName + " / " + car.DailyPrice + " / ");

            }
        }
        else
        {
            Console.WriteLine(Messages.MaintenanceTime);
        }








    }
}
        //EfCarDal inMemoryCar = new EfCarDal();
        //inMemoryCar.Add(new Car { Id = 7, ColorId = 5, BrandId = 2, ModelYear = "2021", DailyPrice = 350000, Description = "Skoda superb 2.0" });

        //foreach (var car in inMemoryCar.GetAll())
        //{
        //    Console.WriteLine(car.Description);
        //}
        //Console.WriteLine();
        //Console.WriteLine("-------------");
        //Console.WriteLine();

        CarManager carManager = new CarManager(new EfCarDal());
         
        //foreach (var car in carManager.GetByDailyPrice(0, 2))
        //{
        //    Console.WriteLine(car.Description);
        //}

        foreach (var car in carManager.GetAll())
        {
            if (car.DailyPrice>0 && car.CarName.Length >2)
            {
                Console.WriteLine(car.CarName);
            }
            else
            {
                Console.WriteLine("ürün bulunamadı.");
            }

            
        }



       
    }
}
