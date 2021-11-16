using Xunit;
using Implementation.Problem3_11_16;
using System.Collections.Generic;

namespace Implementation.Test.Test_Problem3
{
    public class Test_FlipCase
    {
        public static IEnumerable<object[]> GetTests()
        {
            yield return new object[] { "abcABC", "ABCabc" };
            yield return new object[] { "I am A ProgRammer", "i AM a pROGrAMMER" };
            yield return new object[] { "Hello, World!", "hELLO, wORLD!" };
        }

        [Theory]
        [MemberData(nameof(GetTests))]
        public static void Test_FlipCase_1(string input, string expectedResult)
        {
            Assert.Equal(expectedResult, Problem3.FlipCase(input));
        }
    }
}