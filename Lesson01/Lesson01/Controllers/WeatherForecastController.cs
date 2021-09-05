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

        private readonly ValuesHolder _holder;

        public WeatherForecastController(ValuesHolder holder)
        {
            _holder = holder;
        }

        [HttpGet]
        public IActionResult Read()
        {
            return Ok(_holder.Values.OrderBy(d => d.Date));
        }

        [HttpPost]
        public IActionResult Create([FromBody] WeatherForecast input)
        {
            _holder.Values.Add(input);
            return Ok();
        }

       
        [HttpPut]
        public IActionResult Update([FromQuery] DateTime dateToUpdate, [FromQuery] int newTemperature)
        {
            for (int i = 0; i < _holder.Values.Count; i++)
            {
                if (_holder.Values[i].Date == dateToUpdate)
                    _holder.Values[i].TemperatureC = newTemperature;
            }

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] DateTime recordToDelete)
        {
            _holder.Values = _holder.Values.Where(w => w.Date != recordToDelete).ToList();
            return Ok();
        }
    }
}
