using API_Interactive_Lab.Controllers;
using NUnit.Framework;

namespace API_Interactive_Lab.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Test]
        public void TestGetHome()
        {
            // ARRANGE - we set up everything needed for our test
            string expectedContent = "Welcome to the Drinks API!";
            // ACT - we perform the test
            var controller = new HomeController();
            var result = controller.Get();
            // ASSERT - we compare the result to the expected result
            Assert.AreEqual(expectedContent, result);
        }
    }
}
