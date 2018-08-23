using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalcAPI.Models;

namespace CalcAPI.Controllers
{
    [Route("api/calculajuros")]
    public class CompoundInterestController : Controller
    {
        private readonly CompoundInterestModels _model;
        public CompoundInterestController()
        {
            _model = new CompoundInterestModels();
        }
        public class QueryParameters
        {
            public decimal valorinicial { get; set; }
            public int meses { get; set; }
        }

        [HttpGet]
        public IActionResult Get([FromQuery]QueryParameters parameters)
        {
                var compoundInterestResult = _model.CalculateCompoundInterest(parameters.valorinicial, parameters.meses, 0.01m);
                var formatResult = $"Result: {compoundInterestResult}";

                return Ok(formatResult);
        }
    }
}
