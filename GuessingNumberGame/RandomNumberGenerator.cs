using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingNumberGame
{
    public class RandomNumberGenerator
    {
        // properties
        public string RandomNumber { get; set; }

        //constructor
        public RandomNumberGenerator()
        {
            this.RandomNumber = GenerateRandomNumber();
        }

        // private methods
        private string GenerateRandomNumber()
        {
            string generatedNum = "";
            Random randomNumber = new Random();
            int num = 0;
            for (int i = 0; i < 4; i++)
            {
                // Digit number must be b/n 1 and 6 , meaning we need to generate the numbers from 2 -5
                num = randomNumber.Next(6);
                num = num == 0 || num == 1 ? 2 : num;
                generatedNum = generatedNum + num.ToString();
            }
            return generatedNum;
        }
       
    }
}
