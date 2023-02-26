using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        int Mindfulness = 0;
        while (Mindfulness != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
        
            string userChoice = Console.ReadLine();
            Mindfulness = int.Parse(userChoice);

            if (userChoice == "1")
            {
                Console.Clear();

                Breathing messages = new Breathing(
                    "Welcome to the Breathing Activity\n",
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing\n" ,
                    "Thank you",
                    "Breath in...",
                    "Now breath out..."
                    );

                string activityName = messages.GetName();
                string activityDescription = messages.GetActivityDescription();
                string endingMessage = messages.GetEndingMessage();
                string breathIn = messages.GetBreathIn();
                string breathOut = messages.GetBreathOut();
                Console.WriteLine(activityName);
                Console.WriteLine(activityDescription);

                messages.BreathDuration();

                //Pausing
                Console.Write("Going to sleep for a second...");
                messages.Loading();
                Console.Clear();

                for (int x = 0; x < messages.GetActivityTime(); x++)
                {
                    Console.WriteLine(breathIn);
                    messages.BreathingCount();
                    Console.WriteLine(breathOut);
                    messages.BreathingCount();
                    Console.WriteLine();                    
                }

                Console.Clear();
            }

            else if (userChoice == "4")
            {
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine("Error, please enter a valid option");
            }
        }

    }
}