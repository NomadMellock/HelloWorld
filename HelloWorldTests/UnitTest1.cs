using Xunit;
using HelloWorld;

namespace HelloWorldTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello World 4", Program.CreateMessage());
        }
    }
}
