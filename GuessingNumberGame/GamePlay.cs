using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessingNumberGame
{
    public class GamePlay
    {
        public int PlayerAttempt { get; set; }
        public bool CorrectGuess { get; set; }

        public GamePlay()
        {
            this.PlayerAttempt = 1;
            this.CorrectGuess = false;
        }

        public void GetPlayerInput(string randomNumber)
        {
            while (this.PlayerAttempt <= 10 && !CorrectGuess)
            {
                Console.WriteLine("Enter your guess:?");
                string playerNumber = ValidatePlayerInput(Console.ReadLine());

                // invalid inut
                if (string.IsNullOrWhiteSpace(playerNumber))
                {
                    Console.WriteLine("Enter 4 digit number");
                    PlayerAttempt++;
                    continue;
                }
                else
                {
                    CompareTheNumbers(randomNumber, playerNumber);
                }
            }

            if (PlayerAttempt > 10)
            {
                Console.WriteLine($"The random generated number is: {randomNumber}");
                Console.WriteLine("Well you tried!");
                return;
            }

            if (CorrectGuess)
            {
                Console.WriteLine($"You guessed correct in {PlayerAttempt}th turn");
                return;
            }
        }

        private void CompareTheNumbers(string randomNumber, string playerNumber)
        {
            var result = CheckForNumberPlacement(randomNumber, playerNumber);
            Console.WriteLine(result);
            if (randomNumber.Equals(playerNumber))
            {
                Console.WriteLine("You guessed it correct!");
                CorrectGuess = true;
            }
            else
            {
                Console.WriteLine($"You are close. You still have {10 - PlayerAttempt} times to guess. You can do it...");
                PlayerAttempt++;
            }
        }

        private string CheckForNumberPlacement(string randomNumber, string playerNumber)
        {
            var result = "";
            for (int i = 0; i < randomNumber.Length; i++)
            {
                if (playerNumber[i].Equals(randomNumber[i]))
                {
                    result = string.Concat(result, "+");
                }
                else if (randomNumber.Contains(playerNumber[i]))
                {
                    result = string.Concat(result, "-");
                }
                else
                {
                    result = string.Concat(result, " ");
                }
            }
            return result;
        }
        private string ValidatePlayerInput(string playerInput)
        {
            if (!int.TryParse(playerInput, out int putput) || playerInput.Length > 4)
            {

                return "";
            }
            return playerInput;
        }
    }
}
