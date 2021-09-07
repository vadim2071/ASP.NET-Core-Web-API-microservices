using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson02.Controllers
{
    [Route("api/metrics/hdd/left")]
    [ApiController]
    public class HddController : ControllerBase
    {

        public IActionResult GetHi()
        {
            return Ok("Hi, i am hdd controller");
        }

        [HttpGet("agent/{agentId}")]
        public IActionResult GetMetricsFromAgent([FromRoute] int agentId)
        {
            return Ok();
        }

    }
}