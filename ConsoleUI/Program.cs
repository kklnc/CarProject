using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarDto();
            //BrandTest();
            //ColorUpdate();
            //CarList();
            //CarAdd();
            //CarDeleted();
            //UserCustomerDtoTest();
            //RentalAddTest();

        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental
            {
                CarId = 2,
                CustomerId = 2,
                RentDate = DateTime.Now.AddDays(-1),
            };
            rentalManager.Add(rental);
        }

        //private static void CarDto()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal(), new ColorManager(new EfColorDal()));
        //    foreach (var item in carManager.GetCarDetailDtos().Data)
        //    {
        //        Console.WriteLine("{0}-{1}-{2}-{3}", item.CarId, item.CarName, item.ColorName, item.BrandName);
        //    }
        //}


        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.BrandName);
            }
        }

        private static void ColorUpdate()
        {
            ColorManager colorService = new ColorManager(new EfColorDal());
            Color color = new Color
            {
                ColorId = 3,
                ColorName = "Mavi"
            };
            colorService.Update(color);
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new ColorManager(new EfColorDal()));
            Car car = new Car
            {
                CarName = "116",
                DailyPrice = 22400,
                BrandId = 2,
                ColorId = 1,
                Description = "Very Good",
                ModelYear = "2020"
            };

            carManager.Add(car);
        }
        private static void CarDeleted()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new ColorManager(new EfColorDal()));
            Car car = new Car();
            car.Id = 1004;
            carManager.Delete(car);
        }
        private static void CarList()
        {
            CarManager carService = new CarManager(new EfCarDal(), new ColorManager(new EfColorDal()));
            foreach (var car in carService.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
