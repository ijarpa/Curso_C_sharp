using System;
using System.Diagnostics;

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
                    "Well done!!",
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
                    Console.Write(breathIn);
                    messages.BreathingCount();
                    Console.WriteLine();    
                    Console.Write(breathOut);
                    messages.BreathingCount();
                    Console.WriteLine();   
                    Console.WriteLine();                   
                }

                Console.WriteLine(endingMessage);
                messages.Loading();             
                Console.Clear();
            }

            else if (userChoice == "2")
            {
                Console.Clear();

                Reflecting messages = new Reflecting(
                    "Welcome to the Reflecting Activity\n",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n" ,
                    "Well done!!! you have finished the Reflecting Activity",
                    "--- Think of a time when you did something really difficult. ---"
                    );
                
                string activityName = messages.GetName();
                string activityDescription = messages.GetActivityDescription();
                string endingMessage = messages.GetEndingMessage();
                string startPrompt = messages.GetStartPrompt();

                Console.WriteLine(activityName);
                Console.WriteLine(activityDescription);

                messages.ReflectDuration();

                //Pausing
                Console.Write("Going to sleep for a second...");
                messages.Loading();
                Console.WriteLine("Consider the following prompt\n");
                Console.WriteLine(startPrompt);
                Console.WriteLine("\nWhen you have something in mind, press enter to continue:");
                Console.ReadLine();
                Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
                Console.Write("you may begin in: ");
                messages.CountLoading();
                Console.WriteLine();  
  
                Console.Write("> How did you feel when it was complete?");
                messages.ReflectCount();
                Console.WriteLine();    
                Console.Write("> What is your favorite thing about this experience?");
                messages.ReflectCount();
                Console.WriteLine();   
                Console.WriteLine();                   

                Console.WriteLine(endingMessage);
                messages.Loading();             
                Console.Clear();
            }

            else if (userChoice == "3")
            {
                Console.Clear();

                Listing messages = new Listing(
                    "Welcome to the Listing Activity\n",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in certain area.\n" ,
                    "Well done!!! you have finished the Listing Activity",
                    "--- When have you felt the Holy Ghost this month?. ---"
                    );

                string activityName = messages.GetName();
                string activityDescription = messages.GetActivityDescription();
                string endingMessage = messages.GetEndingMessage();
                string startPrompt = messages.GetStartPrompt();

                Console.WriteLine(activityName);
                Console.WriteLine(activityDescription);

                messages.ListingDuration();

                //Pausing
                Console.Write("Going to sleep for a second...");
                messages.Loading();
                Console.WriteLine();                
    
                Console.WriteLine("List as many responses you can to the following prompt:\n");
                Console.WriteLine(startPrompt);
                Console.Write("you may begin in: ");
                messages.CountLoading();
                Console.WriteLine();

                int duration = messages.GetActivityTime();
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                string linea;

                while (stopWatch.Elapsed.TotalSeconds < duration) {
                    Console.Write("> ");
                    linea = Console.ReadLine();
                }

                stopWatch.Stop();
                Console.WriteLine("Time over!");
                Console.WriteLine(endingMessage);
                messages.Loading();
                Console.Clear();
            }

            else if (userChoice == "4")
            {
                Console.WriteLine("Good bye!!");
            }
            else
            {
                Console.WriteLine("Error, please enter a valid option");
            }
        }

    }
}