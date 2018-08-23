using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcAPI.Models;
using CalcAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CalcAPI.Controllers
{
    [Route("api/calculajuros")]
    public class CompoundInterestController : Controller
    {
        private readonly CompoundInterestServices _service;
        private readonly IConfiguration _config;
        public CompoundInterestController(IConfiguration config)
        {
            _service = new CompoundInterestServices();
            _config = config;
        }

        [HttpGet]
        public IActionResult Get([FromQuery]CompoundInterestInput parameters)
        {
            var rate = Convert.ToDecimal(_config["ConfigurationService:Rate"]);

            var compoundInterestResult = _service.CalculateCompoundInterest(parameters.valorinicial, parameters.meses, rate);
            var formatResult = $"Result: {compoundInterestResult}";

            return Ok(formatResult);
        }
    }
}
