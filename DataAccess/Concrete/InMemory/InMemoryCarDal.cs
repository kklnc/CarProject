using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            { 
                new Car { Id = 1,BrandId = 1, CarName ="320",ColorId=1,ModelYear="2010",DailyPrice=100,Description="Good"},
                new Car { Id = 2,BrandId = 1, CarName ="520",ColorId=2,ModelYear="2010",DailyPrice=1000,Description="Good"},
                new Car { Id = 3,BrandId = 2, CarName ="A3",ColorId=2,ModelYear="2010",DailyPrice=1000,Description="Good"},
                new Car { Id = 4,BrandId = 2, CarName ="A4",ColorId=1,ModelYear="2010",DailyPrice=1000,Description="Good"},
                new Car { Id = 5,BrandId = 2, CarName ="A1",ColorId=1,ModelYear="2010",DailyPrice=1000,Description="Good"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete= _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c=>c.BrandId==brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetailsById(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate=_cars.SingleOrDefault(c=>c.Id==car.Id);
            carUpdate.CarName = car.CarName;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.ColorId = car.ColorId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
