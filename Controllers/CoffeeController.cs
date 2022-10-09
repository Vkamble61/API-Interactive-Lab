using Microsoft.AspNetCore.Mvc;
using API_Interactive_Lab.Models;

namespace API_Interactive_Lab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("lover")]
        public string GetCoffeeLover()
        {
            return "I like coffee!";
        }

        [HttpGet()]
        public Coffee GetDefaultCoffeeNameAndId()
        {
            Coffee coffee = new();

            coffee.CoffeeId = -1;
            coffee.CoffeeName = "Latte";

            return coffee;
        }

        [HttpGet("{name}")]
        public Coffee GetCoffeeNameAndId(string? name)
        {
            Coffee coffee = new();
            if (String.IsNullOrEmpty(name))
            {
                coffee.CoffeeId = -1;
                coffee.CoffeeName = "Latte";
            }
            else
            {
                coffee.CoffeeId = 7;
                coffee.CoffeeName = name;
            }

            return coffee;
        }
    }
}
