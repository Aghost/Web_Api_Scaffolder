﻿using Microsoft.AspNetCore.Mvc;
using PROJECTNAME.Data;
using PROJECTNAME.Business.Interfaces;

namespace PROJECTNAME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiController : ControllerBase
    {
        private readonly ICalculatePiService calculatePiService;

        public PiController(ICalculatePiService calculatePiService) {
            this.calculatePiService = calculatePiService;
        }

        /*
        [HttpGet]
        [Route("add/{number}")]
        public IActionResult Add(int number) {
            return Ok(new {
                result = (calculatePiService.Add(number))
            });
        }
        */
        [HttpGet]
        [Route("add/{number}")]
        public IActionResult Add(int number) {
            return Ok(calculatePiService.Add(number));
        }

        [HttpGet]
        [Route("minus/{number}")]
        public IActionResult Minus(int number) {
            return Ok(calculatePiService.Minus(number));
        }
    }
}
