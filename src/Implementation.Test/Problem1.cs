using System;
using Xunit;

using Implementation.Problem1;

namespace Implementation.Test
{
    public class Problem1
    {
        [Theory]
        [InlineData(new object[] { 1, 1, 1 })]
        [InlineData(new object[] { 3, 7, 1 })]
        [InlineData(new object[] { 3, 9, 3 })]
        [InlineData(new object[] { 18, 180, 18 })]
        public void Test_GCD(int a, int b, int actual)
        {
            Assert.Equal(Week1.GCD(a, b), actual);
        }

        [Fact]
        public void Test_UniqueFract()
        {
            double sum = Week1.UniqueFract();

            Assert.Equal(13.5, sum);
        }
    }
}
