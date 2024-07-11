using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCarDal : ICarDal
    {

        List<Car> _cars;

        public EfCarDal()
        {
            _cars = new List<Car>
            {
               new Car {Id =1, BrandId =1, ColorId =1, CarName="Volkswagen", ModelYear = "2022", DailyPrice = 450000, Description = "Volkswagen Jetta 1.6 Primeline"},
               new Car {Id =2, BrandId =2, ColorId =2, CarName="Toyota",ModelYear ="2015", DailyPrice = 350000, Description = "Toyota Corolla 1.6 "},
               new Car {Id =3, BrandId =1, ColorId =3, CarName="Skoda", ModelYear = "2019", DailyPrice = 370000, Description = "Skoda Octavia 1.6 Elite e-Tec"},
               new Car {Id =4, BrandId =2, ColorId =2, CarName="Skoda",ModelYear = "2023", DailyPrice = 650000, Description = "Skoda Octavia 1.6 TDI"},
               new Car {Id =5, BrandId =3, ColorId =1, CarName="Volkswagen", ModelYear = "2021", DailyPrice = 380000, Description = "Volkswagen Jetta 2.0 Comfortline"},
               new Car {Id =6, BrandId =3, ColorId =3, CarName="Porsche", ModelYear = "2018", DailyPrice = 360000, Description = "Porsche Cayenne"},
            };


        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            try
            {
                return _cars;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _cars.Where(c => c.ColorId == categoryId).ToList();
        }

        public void GetById(Car car)
        {
            
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
