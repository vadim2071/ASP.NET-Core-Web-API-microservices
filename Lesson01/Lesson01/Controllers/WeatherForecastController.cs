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
        private readonly List<TempTime> _holder;

        public WeatherForecastController(List<TempTime>  holder)
        {
            _holder = holder;
        }

        [HttpGet]
        public IActionResult Read()
        {
            return Ok(_holder.OrderBy(t => t.time));
        }

        [HttpPost]
        public IActionResult Create([FromBody] TempTime newInput)
        {
            if (_holder.TrueForAll(t => newInput.time != t.time))
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
                if (_holder[i].time == timeToUpdate)
                    _holder[i].temp = newTempValue;
            }

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] TempTime recordToDelete)
        {
            if (_holder.TrueForAll(t => recordToDelete.time == t.time))
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
