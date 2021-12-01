using System;

namespace Implementation.RockPaperScissors
{
    public class RPS
    {
        public string Play(string player1, string player2)
        {
            switch ((player1, player2))
            {
                case ("rock", "rock"):
                    return "TIE";
                case ("rock", "paper"):
                    return "Player 2 wins";
                case ("rock", "scissors"):
                    return "Player 1 wins";
                case ("paper", "rock"):
                    return "Player 1 wins";
                case ("paper", "paper"):
                    return "TIE";
                case ("paper", "scissors"):
                    return "Player 2 wins";
                case ("scissors", "rock"):
                    return "Player 2 wins";
                case ("scissors", "paper"):
                    return "Player 1 wins";
                case ("scissors", "scissors"):
                    return "TIE";
                default:
                    throw new ArgumentException("Invalid input");
            }
        }
    }
}