using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program Launched");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter user name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter user number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        
    }

    static int SquareNumber(int number)
    {
        
    }

    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        
    }
}