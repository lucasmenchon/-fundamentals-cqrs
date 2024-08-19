using Microsoft.AspNetCore.Mvc;

namespace FundamentalsCqrs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
       
    }
}
