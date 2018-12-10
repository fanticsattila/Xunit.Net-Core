using System;
using Xunit;

namespace Calculations.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 35, 45);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));
            Assert.Equal("Hello", exceptionDetails.Message);
        }
    }
}
