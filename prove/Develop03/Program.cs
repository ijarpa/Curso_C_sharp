using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // call classes
        ScriptureReference reference = new ScriptureReference("John 3:16");
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");
        HideWords hideListClass = new HideWords();
        
        // lists
        List<string> scriptureWords = scripture.GetScriptureWords();
        List<string> hiddenWords = hideListClass.GetHiddenScripture();

        Console.WriteLine(reference.GetScriptureReference()); //return the scripture 
        Console.WriteLine(string.Join(" ", scriptureWords));

        List<int> selectedIndices = new List<int>();
        Random rand = new Random();

        while (selectedIndices.Count < scriptureWords.Count)
        {
            Console.WriteLine("Type 'hide' to hide 3 new words, or 'quit' to exit.\n");
                Console.Write(">");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else if (input == "hide")
            {
                int missingWords = scriptureWords.Count - selectedIndices.Count; //count of words that are not hidden

                if (missingWords < 3)
                {
                    for (int i = 0; i  < missingWords; i++)
                    {
                        int index = rand.Next(0, scriptureWords.Count);
                        while (selectedIndices.Contains(index))
                        {
                            index = rand.Next(0, scriptureWords.Count);
                        }
                        selectedIndices.Add(index);
                        scriptureWords[index] = hiddenWords[index];
                    }
                    Console.Clear();
                    Console.WriteLine(string.Join(" ", scriptureWords));
                    break;
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int index = rand.Next(0, scriptureWords.Count);
                        while (selectedIndices.Contains(index))
                        {
                            index = rand.Next(0, scriptureWords.Count);
                        }
                        selectedIndices.Add(index);
                        scriptureWords[index] = hiddenWords[index];
                    }
                    Console.Clear();
                    Console.WriteLine(string.Join(" ", scriptureWords));
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

    }
}
