using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 of Selection Statments Exercises
            //Guess number based on user input
            var r = new Random();
            var favNumber = r.Next(1, 10);
            Console.WriteLine("Let's play a game where you guess my favorite number.");
            Console.WriteLine("Type in your guess (any number between 1 and 10).");
            var userGuess = int.Parse(Console.ReadLine());

            if (userGuess > favNumber)
            {
                Console.WriteLine($"Sorry, your guess is too high...My favorite number is {favNumber}... ");
            }

            else if(userGuess < favNumber)
            {
                Console.WriteLine($"Sorry Your guess is too low...My favorite number is {favNumber}... ");
            }

            else
            {
                Console.WriteLine($"Wow!!!! {favNumber}!!! You guessed my favorite number!!!!!Congratulations");
            }

            //Part 2 of Selection Statements Exercise...








        }
    }
}
