using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (MyCarContext context = new MyCarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new CarDetailDto()
                             {
                                 ImagePath = (from x in context.CarImages where x.CarId == ca.Id select x.ImagePath).FirstOrDefault(),
                                 BrandId = ca.BrandId,
                                 ColorId = ca.ColorId,
                                 Id = ca.Id,
                                 CarName = ca.CarName,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ModelYear = ca.ModelYear
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }

        }

        public CarDetailDto GetCarDetailsById(Expression<Func<CarDetailDto, bool>> filter)
        {
            using (MyCarContext context = new MyCarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new CarDetailDto()
                             {
                                 ImagePath = (from x in context.CarImages where x.CarId == ca.Id select x.ImagePath).FirstOrDefault(),
                                 BrandId = ca.BrandId,
                                 ColorId = ca.ColorId,
                                 Id = ca.Id,
                                 CarName = ca.CarName,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ModelYear = ca.ModelYear
                             };

                return result.FirstOrDefault(filter);
            }
        }
    }
}
