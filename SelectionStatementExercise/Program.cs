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

            Console.WriteLine("Please choose from the following subjects: Physical Education, History, Math, Reading, and Science.");
            Console.WriteLine("Please enter your favorite subject...");
            string subject = Console.ReadLine().ToLower;

            switch (subject)
            {
                case "pe":
                case "physical education":
                    Console.WriteLine("Your favorite subject is pe.");
                    break;
                case "history":
                    Console.WriteLine("Your favorite subject is history.");
                    break;
                case "math":
                    Console.WriteLine("Your favorite subject is math.");
                    break;
                case "reading":
                    Console.WriteLine("Your favorite subject is reading.");
                    break;
                case "science":
                    Console.WriteLine("Your favorite subject is science.");
                    break;
                default:
                    Console.WriteLine("This subject is not in the list.  Please check your spelling and try again.");
                    break;
            }
        }
        
    }
}
