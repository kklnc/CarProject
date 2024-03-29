﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _colorService.GetAll();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Color color)
        {
            var result = _colorService.Add(color);

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var result = _colorService.GetColor(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Updated(Color color)
        {
            var result = _colorService.Update(color);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Delete(color);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
