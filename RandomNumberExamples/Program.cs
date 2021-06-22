using System;

namespace RandomNumberExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            // Default
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            // Specified max
            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            // Range (d6)
            int diceRoll = random.Next(1, 7);
            Console.WriteLine(diceRoll);

            // Random from 0.0 up to 1.0
            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble);
            
            // 1 to 100 using NextDouble
            Console.WriteLine("1 to 100: {0}", Math.Round(randomDouble * 100));

            // Coin toss and convert to bool
            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);
        }
    }
}
