using Xunit;
using Implementation.RockPaperScissors;
using System.Collections.Generic;

namespace Implementation.Test.RockPaperScissors
{
    public class RPS_Test
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { "rock", "rock", "TIE" };
            yield return new object[] { "rock", "paper", "Player 2 wins" };
            yield return new object[] { "rock", "scissors", "Player 1 wins" };
            yield return new object[] { "paper", "rock", "Player 1 wins" };
            yield return new object[] { "paper", "paper", "TIE" };
            yield return new object[] { "paper", "scissors", "Player 2 wins" };
            yield return new object[] { "scissors", "rock", "Player 2 wins" };
            yield return new object[] { "scissors", "paper", "Player 1 wins" };
            yield return new object[] { "scissors", "scissors", "TIE" };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test_RockPaperScissors(string player1, string player2, string expected)
        {
            // Arrange
            var rps = new RPS();

            // Act
            var result = rps.Play(player1, player2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}