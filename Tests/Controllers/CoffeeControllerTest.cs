using API_Interactive_Lab.Controllers;
using API_Interactive_Lab.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace API_Interactive_Lab.Tests.Controllers
{
    public class CoffeeControllerTest
    {
        [Test]
        public void TestGetCoffeeLover()
        {
            // ARRANGE - we set up everything needed for our test
            string expectedContent = "I like coffee!";
            // ACT - we perform the test
            var controller = new CoffeeController();
            var result = controller.GetCoffeeLover();
            // ASSERT - we compare the result to the expected result
            Assert.AreEqual(expectedContent, result);
        }
        [Test]
        public void TestGetCoffeeWithoutParams()
        {
            Coffee expectedCoffee = new Coffee
            {
                CoffeeName = "Latte",
                CoffeeId = -1
            };
            var controller = new CoffeeController();

            var result = controller.GetDefaultCoffeeNameAndId();
            Assert.AreEqual(expectedCoffee.CoffeeName, result.CoffeeName);
            Assert.AreEqual(expectedCoffee.CoffeeId, -1);
        }
        [Test]
        public void TestGetCoffeeNameAndCoffeeId()
        {
            string name = "cappuccino";
            Coffee expectedCoffee = new Coffee
            {
                CoffeeName = name,
                CoffeeId = 7
            };
            var controller = new CoffeeController();
            var result = controller.GetCoffeeNameAndId(name);
            Assert.AreEqual(expectedCoffee.CoffeeName, result.CoffeeName);
            Assert.AreEqual(expectedCoffee.CoffeeId, result.CoffeeId);

        }
    }
}
