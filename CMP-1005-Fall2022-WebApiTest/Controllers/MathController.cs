using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMP_1005_Fall2022_WebApiTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet]
        public int Add(int left, int right)
        {
            return left + right;
        }

        [HttpGet]
        public int Subtract(int left, int right)
        {
            return left - right;
        }
    }
}
