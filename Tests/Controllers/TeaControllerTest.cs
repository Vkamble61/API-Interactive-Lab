using API_Interactive_Lab.Controllers;
using NUnit.Framework;

namespace API_Interactive_Lab.Tests.Controllers
{   
    public class TeaControllerTest
    {
        [Test]
        public void TestGetTea()
        {
            string expectedContent = "I Love Tea!";

            var controller = new TeaController();
            var result = controller.Get();
            Assert.AreEqual(expectedContent, result);

        }
    }
}
