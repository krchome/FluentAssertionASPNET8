using FluentAssertions;

namespace FluentAssertionASPNET8
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Write a unit test for me using fluent assertions
            //The test should check if a is equal to b
            var a = 10;
            var b = 10;
            //The test should pass
            a.Should().Be(b);
            a = 20;
        }
    }
}