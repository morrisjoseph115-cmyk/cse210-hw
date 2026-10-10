// EXCEEDING REQUIREMENTS:
// I managed to get the journal to also keep the mood of the user when entered.
// The mood is displayed with each entry and is saved with each file export. Interesting stuff.

using System;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {
        Cipher cipher = new Cipher();

        string encrypted = cipher.Encrypt("Hello World!");
        string decrypted = cipher.Decrypt(encrypted);

        Console.WriteLine(encrypted);
        Console.WriteLine(decrypted);
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

            Console.WriteLine(">");
            
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

                // this is where the magic prompt pulls happen. this is interesting. lol

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
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                journal.AddEntry(newEntry);

            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                //Console.WriteLine("Load selected...");
                //Actually uses the retreived file.
                
                Console.Write("Enter the file path or filename to load from:");
                Console.Write("Note this is also case and pathing sensitive...");

                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
                Console.WriteLine($"File loaded successfully!");
            }

            else if (choice == 4)
            {


                // ---------------------------------------------------------------------------------------------------------------------------------------
                //Console.WriteLine("Save selected..."); We are going to do something more refined with this soon.

                //Console.WriteLine("What filename would you like to save to? :"); // gives the new prompt
                //string filename = Console.ReadLine();                            // makes a string, then uses the return from the console to give the filename.

                //journal.SavetoFile(filename);                                    // runs our function... or tries to.
                //Console.WriteLine($"Saved to Path: {Path.GetFullPath(filename)}");
                // ---------------------------------------------------------------------------------------------------------------------------------------


                // made some changes here, thought it would be a good idea to set the path for the file to be saved. kinda lost it in the debug folder.
                // it was hiding inside a dotfile and thats not easy to look at. so I made changes...
                Console.Write("Enter the file path or the filename to save to: ");
                string filename = Console.ReadLine();

                journal.SavetoFile(filename);

                Console.WriteLine($"Journal entry saved to : {Path.GetFullPath(filename)}");
                Console.WriteLine($"File written successfully!");


            }
        }


    }
}