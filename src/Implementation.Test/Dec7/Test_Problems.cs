using Xunit;
using Implementation.Dec7;
using System.Collections.Generic;

namespace Implementation.Test.Dec7
{
    public class Test_Problems
    {
        [Theory]
        [InlineData(new object[] { 1, 1, 1 })]
        [InlineData(new object[] { 3, 7, 1 })]
        [InlineData(new object[] { 3, 9, 3 })]
        [InlineData(new object[] { 18, 180, 18 })]
        public void Test_GCD(int a, int b, int expected)
        {
            int actual = Fractions.GCD(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_UniqueFract()
        {
            double sum = Fractions.UniqueFract();

            Assert.Equal(13.5, sum);
        }

        public static IEnumerable<object[]> OvertimeData()
        {
            yield return new object[] { new List<double>() { 9, 17, 30, 1.5 }, "$240.00" };
            yield return new object[] { new List<double>() { 16, 18, 30, 1.8 }, "$84.00" };
            yield return new object[] { new List<double>() { 13.25, 15, 30, 1.5 }, "$52.50" };
        }

        [Theory]
        [MemberData(nameof(OvertimeData))]
        public void Test_Overtime(List<double> args, string expected)
        {
            string actual = Overtime.OverTime(args);
            Assert.Equal(expected, actual);
        }

    }

}