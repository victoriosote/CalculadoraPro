using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAlculadora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public int sumaget(int a, int b)
        {
            return a + b;
        }
        [HttpPost]
        public int sumapost([FromHeader] int a, [FromHeader] int b)
        {
            return a + b;
        }
    }
}
