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
        public void Test_GCD(int a, int b, int expected)
        {
            int actual = Week1.GCD(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_UniqueFract()
        {
            double sum = Week1.UniqueFract();

            Assert.Equal(13.5, sum);
        }

        [Theory]
        [InlineData(new object[] { 2, 1 })]
        [InlineData(new object[] { 3, 7 })]
        [InlineData(new object[] { 10, 6 })]
        public void Test_Collatz(int input, int expected)
        {
            int actual = Week1.Collatz(input);
            Assert.Equal(expected, actual);
        }
    }
}
