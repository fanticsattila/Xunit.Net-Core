using System;
using Xunit;
using MockTest.Repositories;
using Moq;
using MockTest.Controllers;

namespace CustomerTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var repo = new Mock<ICustomerRepository>();
            var controller = new HomeController(repo.Object);
            controller.Index(new MockTest.Models.CustomerModel() { FirstName = "John", LastName = "Snow" });

        }
    }
}
