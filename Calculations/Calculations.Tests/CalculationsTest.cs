using System.Collections.Generic;
using Xunit;

namespace Calculations.Tests
{
    public class CalculationsTest
    {
        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            var calc = new Calculations();
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboIncludes13()
        {
            var calc = new Calculations();
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        public void FiboDoesNotInclude4()
        {
            var calc = new Calculations();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        public void CheckCollection()
        {
            var expCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = new Calculations();
            Assert.Equal(expCollection, calc.FiboNumbers);
        }
    }
}
