using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetailsDtos();

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);   
        IDataResult<Car> GetById(int id);


        List<Car> GetAll();
        List<Car> GetCarByBrandId(int brandId);
        List<Car> GetCarByColorId(int colorId);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByCarName(string carNameLength);
       
       

    }
}
