using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests
{
    public class CalculatorFixture : IDisposable
    {
        public Calculations Calc => new Calculations();

        public void Dispose()
        {
            
        }
    }
    public class CalculationsTest : IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream _memoryStream;

        public CalculationsTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _testOutputHelper.WriteLine("Constructor");

            _memoryStream = new MemoryStream();
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            var calc = _calculatorFixture.Calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            var calc = _calculatorFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            var calc = _calculatorFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            _testOutputHelper.WriteLine("Test start at {0}", DateTime.Now);
            var expCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            _testOutputHelper.WriteLine("Creating an instance of Calculator class...");
            var calc = _calculatorFixture.Calc;
            _testOutputHelper.WriteLine("Asserting...");
            Assert.Equal(expCollection, calc.FiboNumbers);
            _testOutputHelper.WriteLine("End.");
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(1);
            Assert.True(result);
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsFalse()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(2);
            Assert.False(result);
        }

        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }
    }
}
