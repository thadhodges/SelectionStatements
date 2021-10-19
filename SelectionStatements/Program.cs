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
                Console.WriteLine();
            }

            //Part 2 of Selection Statements Exercise...

            //"Here is an example of a random day generator using switch statement"

            Console.WriteLine("Here is an example of a random day generator using switch statement");
            var day = new Random();
            var randomDay = day.Next(0, 10);
            switch (randomDay)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine($"System error, selection must be a whole number between 0 and 6!!!");
                    break;
                    

            }
            Console.WriteLine();
            Console.WriteLine();
            //Part 2 Exercise

            Console.WriteLine($"Let's get to know each other a little more.../n" +
                $"Let's talk about what our favorite subjects were in High School./n" +
                $"What was your favorite Subject?  Use lower case please...");
            var subject = Console.ReadLine();

            switch (subject)

            {
                case "math":
                    Console.WriteLine($"Sorry, I didn't really like {subject} very much...");
                    break;

                case "history":
                    Console.WriteLine($"Now I kinda sorta liked {subject}, but it wasn't my fav...");
                    break;

                case "physics":
                    Console.WriteLine($"Now I kinda sorta liked {subject}, but it wasn't my fav...");
                    break;

                case "biology":
                    Console.WriteLine($"Now we're talking love-love-loved {subject}, my absolute fav...");
                    break;

                case "english":
                    Console.WriteLine($"Now I kinda sorta liked {subject}, but it wasn't my fav...");
                    break;

                default:
                    Console.WriteLine("Well, I guess we just don't have that in common...Have a great day.");
                    break;

            }







        }
    }
}
