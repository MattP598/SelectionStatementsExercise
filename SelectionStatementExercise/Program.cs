using System;

namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favoriteNum = r.Next(1, 1000);
            int guess;

            Console.WriteLine("Welcome to the number guessing game!");
            
            Console.WriteLine("Please enter a number between 1 and 1000: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > favoriteNum)
            {
                Console.WriteLine("Your guess is too high!");
                Console.WriteLine("The correct number was "+favoriteNum);
            }
            else if (guess < favoriteNum)
            {
                Console.WriteLine("Your guess is too low!");
                Console.WriteLine("The correct number was " + favoriteNum);
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}
