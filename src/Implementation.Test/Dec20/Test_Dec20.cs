using System.Collections.Generic;
using Xunit;

using D20 = Implementation.Dec20;

namespace Implementation.Test.Dec20
{
    public class Test_Dec20
    {

        public static IEnumerable<object[]> GetDeadEndData()
        {
            yield return new object[] { 5L, 2L, 1L };
            yield return new object[] { 11L, 7L, 11440L };
            yield return new object[] { 123456789L, 2L, 5555555505L };
            yield return new object[] { 101L, 9L, 136804096L };
        }

        [Theory]
        [MemberData(nameof(GetDeadEndData))]
        public void Test_DeadEnd(long arg, long expectedCount, long lastTerm)
        {
            var result = D20.Dec20.DeadEnd(arg);
            Assert.Equal(expectedCount, result[0]);
            Assert.Equal(lastTerm, result[1]);
        }

        public static IEnumerable<object[]> GetMagicSquareData()
        {
            yield return new object[] {
                new List<List<int>> {
                    new List<int> { 2, 7, 6 },
                    new List<int> { 9, 5, 1 },
                    new List<int> { 4, 3, 8 },
                },
                true
            };
            yield return new object[] {
                new List<List<int>> {
                    new List<int> { 16, 3, 2, 13 },
                    new List<int> { 5, 10, 11, 8 },
                    new List<int> { 9, 6, 7, 12 },
                    new List<int> { 4, 15, 14, 1 }
                },
                true
            };
            yield return new object[] {
                new List<List<int>> {
                    new List<int> { 1, 14, 14, 4},
                    new List<int> { 11, 7, 6, 9 },
                    new List<int> { 8, 11, 10, 5 },
                    new List<int> { 13, 2, 3, 15 }
                },
                false
            };
        }

        [Theory]
        [MemberData(nameof(GetMagicSquareData))]
        public void Test_IsMagicSquare(List<List<int>> square, bool expected)
        {
            var result = D20.Dec20.IsMagicSquare(square);
            Assert.Equal(expected, result);
        }
    }
}