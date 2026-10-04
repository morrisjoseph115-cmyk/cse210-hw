using System;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        int choice = 0;

        while (choice != 5)
        {

            Console.WriteLine("Please select one of the following choices!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select to continue, use the num keys and ENTER.");
            // left these in for tinkering later, this is really cool, lol!
            // Console.WriteLine("");
            // Console.WriteLine("");

            choice = int.Parse(Console.ReadLine());  

            if (choice == 1)
            {
                Console.WriteLine("Write selected...");
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.WriteLine("Load selected...");
            }

            else if (choice == 4)
            {
                Console.WriteLine("Save selected...");
            }
        }


    }
}