using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _carService.GetAll();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Updated(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetCarDetailDtos")]
        public IActionResult GetCarDetailDtos()
        {
            var result = _carService.GetCarDetailDtos();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("GetColor")]
        public IActionResult GetColor(int id)
        {
            var result = _carService.GetColor(id);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("GetByUnitPrice")]
        public IActionResult GetByUnitPrice(decimal min,decimal max)
        {
            var result = _carService.GetByUnitPrice(min,max);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("GetAllByColorId")]
        public IActionResult GetAllByColorId(int colorId)
        {
            var result = _carService.GetAllByColorId(colorId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("GetAllByBrandId")]
        public IActionResult GetAllByBrandId(int brandId)
        {
            var result = _carService.GetAllByBrandId(brandId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("getcarsbybrandidandcolorid")]
        public IActionResult GetCarsByBrandIdAndColorId(int brandId, int colorId)
        {
            var result = _carService.GetCarsByBrandIdAndColorId(brandId, colorId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcardetailsbyid")]
        public IActionResult GetCarDetailsById(int carId)
        {
            var result = _carService.GetCarDetailsById(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
