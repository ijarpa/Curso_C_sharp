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
        }

    }
}