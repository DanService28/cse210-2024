using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 100);

        int guessedNumber = -1;

        while (number != guessedNumber)
        {
            Console.Write("Guess a number among 1-100? ");
            guessedNumber = int.Parse(Console.ReadLine());

            if (number > guessedNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guessedNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}