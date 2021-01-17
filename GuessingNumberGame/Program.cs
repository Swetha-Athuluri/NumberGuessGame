using System;

namespace GuessingNumberGame
{
    public class Program
    {
        const string ReadyToPlay = "yes";
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number guessing game");
            StartGame();
        }

        private static void StartGame()
        {
            Console.WriteLine("Do you want to play GUESS GAME(yes/no):");
            var readyToPlay = Console.ReadLine();
            if (readyToPlay.ToLower().Equals(ReadyToPlay))
            {
                RandomNumberGenerator randomNumber = new RandomNumberGenerator();
                DisplayGameInstructions();
                PlayGame(randomNumber.RandomNumber);
            }
            else
            {
                EndGame();
            }
        }

        private static void DisplayGameInstructions()
        {
            Console.WriteLine("GAME INSTRUCTIONS");
            Console.WriteLine("The Generated will be of 4 digits and b/n 1 and 6 on each place.");
            Console.WriteLine("If the digit and its place is correct you will see + and if the digit is correct but in wrong place you see -");

        }

        private static void PlayGame(string randomNumber)
        {
            GamePlay play = new GamePlay();
            play.GetPlayerInput(randomNumber);
            StartGame();
        }
        private static void EndGame()
        {
            Console.WriteLine("Thank you for Playing. Have a good Day!");
            Console.Read();
            return;
        }

    }
}