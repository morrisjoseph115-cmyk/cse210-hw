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

        foreach (int value in numbers)
        {
            sum += value;
        }

            Console.WriteLine($"The total sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        int largest = numbers[0];

        foreach (int value in numbers)
            {
                if (value > largest)
                {
                    largest = value;
                }
            }
        Console.WriteLine($"The largest number in list is : {largest}");
        }
    }
}