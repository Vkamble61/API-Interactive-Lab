using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController: ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "I Love Tea!";
        }
    }
}
