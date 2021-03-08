using System;
using Xunit;

namespace SampleLib.Test
{
    public class SampleTest
    {

        [Fact]
        public void TestSay()
        {
            var sample = new Sample();
            Assert.Equal("Hello TDD Boot Camp!", sample.Say());
        }
    }
}
