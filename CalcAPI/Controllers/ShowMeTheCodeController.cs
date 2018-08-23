using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalcAPI.Controllers
{
    [Route("api/showmethecode")]
    public class ShowMeTheCodeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
                return Ok("https://github.com/marcusocosta/CalcSolution");
        }
    }
}
