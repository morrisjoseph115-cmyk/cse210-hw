using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of NUMBERS, type 0 when complete.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

            int sum = 0;

            foreach (int number in numbers);
            {
                sum += number;
            }

            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}