using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [ApiController]
    [Route("")]
    public class HelloWorldController : ControllerBase
    {


        [HttpGet]
        public string Get()
        {
            return "Hello World First Docker File!";
        }
    }
}
