using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.WriteLine("please enter your first name. :");
        firstName = Console.ReadLine();
        Console.ReadLine();
        Console.Write("please enter your last name. :");
        lastName = Console.ReadLine();

        Console.WriteLine($"The full username is :{lastName}_{firstName}");
    }
}