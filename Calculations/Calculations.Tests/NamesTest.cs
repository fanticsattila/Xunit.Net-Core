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
            Assert.StartsWith("Fántics", result, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.EndsWith("Attila", result);
        }
    }
}
