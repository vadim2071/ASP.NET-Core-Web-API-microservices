﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson01
{
    [Route("[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        private readonly ValuesHolder _holder;

        public CrudController(ValuesHolder holder)
        {
            _holder = holder;
        }

        [HttpPost]
        public IActionResult Create([FromQuery] string input)
        {
            _holder.Add(input);
            return Ok();
        }

        [HttpGet]
        public IActionResult Read()
        {
            return Ok(_holder.Get());
        }

        [HttpPut]
        public IActionResult Update([FromQuery] string stringsToUpdate, [FromQuery] string newValue)
        {
            for (int i = 0; i < _holder.Values.Count; i++)
            {
                if (holder.Values[i] == stringsToUpdate)
                    holder.Values[i] = newValue;
            }

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] string stringsToDelete)
        {
            holder.Values = holder.Values.Where(w => w != stringsToDelete).ToList();
            return Ok();
        }

    }
}
