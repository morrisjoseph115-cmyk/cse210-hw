using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade % you have? ");
        string UserResponse = Console.ReadLine();
        int GradePercent = int.Parse(UserResponse);
        string letter = "";

        if (GradePercent >= 90)
        {
            letter = "A";
        }
        else if (GradePercent >= 80)
        {
            letter = "B";
        }
        else if (GradePercent >= 70)
        {
            letter = "C";
        }
        else if (GradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"cool, your grade is an : {letter}");
        if (GradePercent >= 70)
        {
            Console.WriteLine($"Congrats you passed! :)");
        }
        else
        {
            Console.WriteLine($"You Failed, Hope you didn't take out a loan...");
        }
    }
}