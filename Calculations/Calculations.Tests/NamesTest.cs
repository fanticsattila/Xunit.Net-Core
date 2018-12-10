using Xunit;

namespace Calculations.Tests
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullName("Fantics", "Attila");
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            names.NickName = "Fántics Attila";
            Assert.NotNull(names.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("Fántics", "Attila");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
