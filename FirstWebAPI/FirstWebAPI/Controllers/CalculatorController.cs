using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
         //api/calculator/add?x=100&y=20
        [HttpGet("Calculator/add")]
        public int Add(int x,int y)
        {
            return (x + y);
        }
        [HttpGet("/sum")]
        public int Sum(int x, int y)
        {
            return (x + y+1000);
        }

        [HttpPost]
        //api/calculator/sub?x=100&y=20
        public int Sub(int x, int y)
        {
            return (x - y);
        }
        [HttpPut]
        //api/calculator/mul?x=100&y=20
        public int Mul(int x, int y)
        {
            return (x * y);
        }
        [HttpDelete]
        //api/calculator/div?x=100&y=20
        public int Div(int x, int y)
        {
            return (x / y);
        }
    }
}
