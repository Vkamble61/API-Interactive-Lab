using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab.Controllers
{
    [ApiController]
    [Route("")]
    //[Route("/")]
    //[Route("[controller]")]
    //[Route("Noodles")]

    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!";
        }
    }
}
