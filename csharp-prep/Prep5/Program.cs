using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program Launched");
        DisplayWelcome();
        string userName = PromptUserName();
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