using Xunit;

namespace Calculations.Tests
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullName("fántics", "Attila");
            Assert.Equal("Fántics Attila", result);
        }
    }
}
