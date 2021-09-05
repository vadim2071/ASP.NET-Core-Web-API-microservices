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
            return Ok(_holder.Values.OrderBy(d => d.Summary));
        }

        [HttpPost]
        public IActionResult Create([FromBody] WeatherForecast input)
        {
            _holder.Values.Add(input.Summary); //почему-то разрешает только string
            return Ok();
        }

       
        [HttpPut]
        public IActionResult Update([FromQuery] string stringsToUpdate, [FromQuery] string newValue)
        {
            for (int i = 0; i < _holder.Values.Count; i++)
            {
                if (_holder.Values[i] == stringsToUpdate)
                    _holder.Values[i] = newValue;
            }

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] string stringsToDelete)
        {
            _holder.Values = _holder.Values.Where(w => w != stringsToDelete).ToList();
            return Ok();
        }
    }
}
