using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade % you have? ");
        string useresponse = Console.ReadLine();
        int gradepercent = int.Parse(useresponse);
        string lettergrade = "";

        if (gradepercent >= 90)
        {
            lettergrade = "A";
        }
        else if (gradepercent >= 80)
        {
            lettergrade = "B";
        }
        else if (gradepercent >= 70)
        {
            lettergrade = "C";
        }
        else if (gradepercent >= 60)
        {
            lettergrade = "D";
        }
        else
        {
            lettergrade = "F";
        }
        Console.WriteLine($"cool, your grade is an : {lettergrade}");
        if (gradepercent >= 70)
        {
            Console.WriteLine($"Congrats you passed! :)");
        }
        else
        {
            Console.WriteLine($"You Failed, Hope you didn't take out a loan...");
        }
    }
}