﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetricsManagerController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            return Ok();
        }

        [HttpPut("enable/{agentId}")]
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

        [HttpPut("disable/{agentId}")]
        public IActionResult DisableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }
    }

    public class AgentInfo
    {
        public int AgentId { get; set; }

        public Uri AgentAddress { get; set; }

        public AgentInfo(int _agentId, Uri _agentAdress)
        {
            AgentId = _agentId;
            AgentAddress = _agentAdress;
        }
    }
}
