using Xunit;
using Implementation.CodingChallenge11_10;

namespace Implementation.Test.Test_CodingChallenge11_10
{
    public class CharCounter_Test
    {

        private delegate int CountChars(string S);
        private CountChars _CorrectCount;
        private CountChars _SUTCount;
        public CharCounter_Test() : base()
        {
            _CorrectCount = CharCounter.Count_Submitted;
            _SUTCount = CharCounter.Count_OneLine;
        }

        [Theory]
        [InlineData(new object[] { "abcdeffg" })]
        [InlineData(new object[] { "aabbcc" })]
        [InlineData(new object[] { "iamateststringhowaboutthat" })]
        public void Test_Counter(string data)
        {
            int expected = _CorrectCount(data);
            int actual = _SUTCount(data);
            Assert.Equal(expected, actual);
        }
    }
}