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

            // stert menu fluff
            Console.WriteLine("Please select one of the following choices!");
            Console.WriteLine("Select to continue, use the num keys and ENTER.");
            // end menu fluff

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            // left these in for tinkering later, this is really cool, lol!
            // Console.WriteLine("");
            // Console.WriteLine("");

            choice = int.Parse(Console.ReadLine());  

            if (choice == 1)
            {
                // Console.WriteLine("Write selected...");  Leaving it here as a reminder, I am building something great!
                List<string> prompts  = new List<string>()
                {
                    "Who caught my attention the most when I interacted with them today?",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?",
                    "How did I serve others whom needed it?",
                    "Did I set a proper example and follow the Lords example?",
                    "Was I my brothers keeper today?",
                    "Even though there is always tomorrow, what can I do today?",
                    "Did I do a $5 job, or a $20 job?",
                    "Did I do my good turn daily?",
                    "Did I truly do my best today? Go that extra mile?",
                };

                Random random = new Random();
                int promptIndex = random.Next(prompts.Count);
                string prompt = prompts[promptIndex];

                Console.WriteLine(prompt);
                Console.Write(">");
                string response = Console.ReadLine();

                Console.Write("How would you describe your mood? ");
                string mood = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry  newEntry = new Entry();

                newEntry._date = date;
                
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