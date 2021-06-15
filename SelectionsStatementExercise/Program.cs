using System;

namespace SelectionsStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guessing Game -----
            Console.WriteLine("Try to guess my favorite number.");
            Console.WriteLine("What is the upper limit of the range of numbers?");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);
            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess");
            Console.WriteLine("HINT - You only have 1 guess");
            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Too high");
            }
            else if (guess < number)
            {
                Console.WriteLine("Too low.");
            }
            else if (guess < 0)
            {
                Console.WriteLine("Nevermind.");
            }
            else
            {
                Console.WriteLine("Correct!");
            }


            Console.WriteLine("Here, I have another question for you:");


            //Swicth/Case Statement -----
            Console.WriteLine("Hello! What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "science":
                    Console.WriteLine("Science is a good choice.");
                    break;
                case "math":
                    Console.WriteLine("As a computer, I prefer math myself.");
                    break;
                case "history":
                    Console.WriteLine("I like history too, I just always forget it.");
                    break;
                case "gym":
                    Console.WriteLine("Gym class can be pretty fun.");
                    break;
                case "art":
                    Console.WriteLine("Art... sorry, I just don't get it.");
                    break;
                default:
                    Console.WriteLine("Haha trick question! Everyone knows the best subject is recess!");
                    break;

            }

        }
    }
}

