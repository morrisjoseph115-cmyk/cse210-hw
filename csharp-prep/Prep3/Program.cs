using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What number 1~100 do you guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Nope, Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Nope, Lower!");
            }
            else
            {
                Console.WriteLine("You GOT IT! Good Guess!");
            }
        }
    }
}