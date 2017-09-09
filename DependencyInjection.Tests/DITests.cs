using DependencyInjection.Models;
using Moq;
using Xunit;
using DependencyInjection.Controllers;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Infrastructure;

namespace Tests
{
    public class DITests
    {
        [Fact]
        public void ControllerTest()
        {
            // Организация
            var data = new[] { new Product { Name = "Test", Price = 100 } };
            var mock = new Mock<IRepository>();
            mock.SetupGet(m => m.Products).Returns(data);
            TypeBroker.SetTestObject(mock.Object);
            HomeController controller = new HomeController();           

            // Действие
            ViewResult result = controller.Index();

            // Утверждение
            Assert.Equal(data, result.ViewData.Model);

        }
    }
}
