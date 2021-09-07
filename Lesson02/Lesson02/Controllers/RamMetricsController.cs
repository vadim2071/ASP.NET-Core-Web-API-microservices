using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson02.Controllers
{
    public class RamMetricsController : ControllerBase
    {
        [Route("api/metrics/ram/available/[controller]")]
        [ApiController]
        public class NetworkController : ControllerBase
        {
            public IActionResult GetHi()
            {
                return Ok("Hi, i am ram controller");
            }

            [HttpGet("agent/{agentId}")]
            public IActionResult GetMetricsFromAgent([FromRoute] int agentId)
            {
                return Ok();
            }

        }
    }
}
