using System;

namespace number_guessing_game_CS
{
    class Program
    {
        private static int number;
        private static int max;

        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Number Guessing Game");
                Console.Write("\nChoose a difficulty?(easy/medium/hard): ");
                String difficulty = Console.ReadLine().ToUpper();

                if (difficulty == "EASY")
                {
                    Program.max = 10;
                    break;
                }
                else if (difficulty == "MEDIUM")
                {
                    Program.max = 25;
                    break;
                }
                else if (difficulty == "HARD")
                {
                    Program.max = 50;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Input try again!");
                    continue;
                }
            }    

            Random rnd = new Random();
            Program.number = rnd.Next(Program.max);

            while (true)
            {
                Console.WriteLine("A number from 1 to " + Program.max + " has been generated.");
                Console.Write("Make a guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > Program.max || guess < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Your input is out of bounds. Try again.");
                    continue;
                }

                if (guess == Program.number)
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations you won! The number was " + Program.number + "!");
                    break;
                }
                else if (guess > Program.number)
                {
                    Console.Clear();
                    Console.WriteLine("Guess Lower");
                    continue;
                }
                else if (guess < Program.number)
                {
                    Console.Clear();
                    Console.WriteLine("Guess Higher");
                    continue;
                }
            }
        }
    }
}