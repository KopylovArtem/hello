using Microsoft.AspNetCore.Mvc;

namespace hello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyController
    {
        [HttpGet]
        public string Get()
        {
            return "hello";
        }
    }
}
