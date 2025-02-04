using Xunit;

namespace Application.Tests
{
    public class SampleTests
    {
        [Fact]
        public void Test_Passing()
        {
            Assert.True(1 + 1 == 2);
        }

        [Fact]
        public void Test_Failing()
        {
            Assert.False(2 + 2 == 5);
        }
    }
}