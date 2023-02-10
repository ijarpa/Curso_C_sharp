using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // call classes
        Scripture scripture = new Scripture();
        HideWords hideListClass = new HideWords();
        
        // lists
        List<string> scriptureWords = scripture.GetScriptureWords();
        List<string> hiddenWords = hideListClass.GetHiddenScripture();


        Console.WriteLine(string.Join(" ", scriptureWords));

        List<int> selectedIndices = new List<int>();
        Random rnd = new Random();

        while (selectedIndices.Count < scriptureWords.Count)
        {
            Console.WriteLine("Type 'hide' to hide 5 new words, or 'exit' to exit.\n");
            string input = Console.ReadLine();

            if (input == "exit")
            {
                break;
            }
            else if (input == "hide")
            {
                for (int i = 0; i < 5; i++)
                {
                    int index = rnd.Next(0, scriptureWords.Count);
                    while (selectedIndices.Contains(index))
                    {
                        index = rnd.Next(0, scriptureWords.Count);
                    }
                    selectedIndices.Add(index);
                    scriptureWords[index] = hiddenWords[index];
                }
                Console.Clear();
                Console.WriteLine(string.Join(" ", scriptureWords));
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

    }
}
