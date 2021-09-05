using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly List<WeatherForecast> _holder;

        public WeatherForecastController(List<WeatherForecast>  holder)
        {
            _holder = holder;
        }


        [HttpGet]
        public IActionResult Read()
        {
            if (_holder.Count != 0) return Ok(_holder.OrderBy(t => t.Date));
            else return NotFound();

        }

        [HttpPost]
        public IActionResult Create([FromBody] WeatherForecast newInput)
        {
            if (_holder.TrueForAll(t => newInput.Date != t.Date))
            {
                _holder.Add(newInput);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        
        [HttpPut]
        public IActionResult Update([FromQuery] DateTime timeToUpdate, [FromQuery] int newTempValue)
        {
            for (int i = 0; i < _holder.Count; i++)
            {
                if (_holder[i].Date == timeToUpdate)
                    _holder[i].TemperatureC = newTempValue;
            }

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] WeatherForecast recordToDelete)
        {
            if (_holder.TrueForAll(t => recordToDelete.Date == t.Date))
            {
                _holder.Remove(recordToDelete);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
