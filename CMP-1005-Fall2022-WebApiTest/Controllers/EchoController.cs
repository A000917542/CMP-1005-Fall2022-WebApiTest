using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMP_1005_Fall2022_WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        [HttpGet]
        public string Get(string text)
        {
            return text;
        }

        [HttpPost]
        public string Post(string text)
        {
            return text.ToUpper();
        }

        [HttpPut]
        public string Put(string text)
        {
            return text.ToLower();
        }
    }
}
