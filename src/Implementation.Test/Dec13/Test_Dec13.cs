using System.Collections.Generic;
using Implementation.Dec13;
using Xunit;

namespace Implementation.Test.Dec13
{
    /*
    almostPalindrome("abcdcbg") ➞ true
// Transformed to "abcdcba" by changing "g" to "a".
almostPalindrome("abccia") ➞ true
// Transformed to "abccba" by changing "i" to "b".
almostPalindrome("abcdaaa") ➞ false
// Can't be transformed to a palindrome in exactly 1 turn.

almostPalindrome("1234312") ➞ false
*/

    public class Test_Dec13
    {

        public static IEnumerable<object[]> PalindromeData()
        {
            yield return new object[] { "abcdcbg", true };
            yield return new object[] { "abccia", true };
            yield return new object[] { "abcdaaa", false };
            yield return new object[] { "1234312", false };
        }

        [Theory]
        [MemberData(nameof(PalindromeData))]
        public void Test_AlmostPalindrome(string input, bool expected)
        {
            Assert.Equal(expected, Palindromes.almostPalindrome(input));
        }

        public static IEnumerable<object[]> ClimbData()
        {
            yield return new object[] { 1, 1 };
            yield return new object[] { 2, 2 };
            yield return new object[] { 5, 8 };
        }

        [Theory]
        [MemberData(nameof(ClimbData))]
        public void Test_WaysToClimb(int input, int expected)
        {
            Assert.Equal(expected, Staircase.waysToClimb(input));
        }
    }
}