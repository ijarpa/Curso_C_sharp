using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Entry entryClass = new Entry();  
        DateTime currentDate = DateTime.Now;
        Journal journalClass = new Journal();

        string dateUser = currentDate.ToString("MM-dd-yyyy");
        string activeEntry = "";
        string activePrompt = "";


        Console.WriteLine("Welcome to the Journal Program!");
        int journalProgram = 0;
        while (journalProgram != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do (enter the number of your choice): ");

            string userChoice = Console.ReadLine();
              
            if (userChoice == "1")
            {
                string prompt = entryClass.promptQuestion();
                activePrompt = prompt;
                Console.WriteLine(activePrompt);
                Console.Write(">");
                string userAnswer = Console.ReadLine();
                activeEntry = userAnswer;
                Console.WriteLine("");
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("\nYour Journal files: ");
                journalClass.showFiles();
                Console.WriteLine("");
            }
            else if (userChoice == "3")
            {
                journalClass.readFile();
                Console.WriteLine("");
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("");
                Console.WriteLine("Do you want to save the following entry: ");
                Console.WriteLine($"Text: {activeEntry}");
                Console.WriteLine("yes / no: ");
                Console.Write(">");
                string saveQuestion = Console.ReadLine();


                if (saveQuestion.ToLower() == "yes")
                {
                    journalClass.saveTextFile(dateUser, activePrompt, activeEntry);
                    Console.WriteLine("Your file has been saved");
                }
                else
                {
                    Console.WriteLine("Returning to main menu");
                }
                Console.WriteLine("");
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Good bye!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Error, please enter a valid option");
            }
        }        
    }
}


class Entry
{
    public string promptQuestion()
    {
        List<string> questionsList = new List<string>()
        {
        "What was the best part of my day?",
        "What do you hope for tomorrow?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is the most important thing you want to remember from today?",
        "What did you learn today that you want to remember for the future?",
        "What thing you would change of this day?"
        };

        DateTime dayForPrompt = DateTime.Now;
        string dayOfWeek = dayForPrompt.DayOfWeek.ToString();

        if (dayOfWeek == "Monday")
        {
            return questionsList[0];
        }
        else if (dayOfWeek == "Tuesday")
        {
            return questionsList[1];
        }
        else if (dayOfWeek == "Wednesday")
        {
            return questionsList[2];
        }
        else if (dayOfWeek == "Thursday")
        {
            return questionsList[3];          
        }
        else if (dayOfWeek == "Friday")
        {
            return questionsList[4]; 
        }
        else if (dayOfWeek == "Saturday")
        {
            return questionsList[5];
        }
        else if (dayOfWeek == "Sunday")
        {
            return questionsList[6];
        }
        else
        {
            return "Error";
        }
    }
    public string userText;
}

class Journal
{
    List<string> filesNames;
    public void saveTextFile(string dateUser, string activePrompt, string activeEntry)
    {

        DateTime dayForPrompt = DateTime.Now;
        string dayOfWeek = dayForPrompt.DayOfWeek.ToString();
        
        string fileName = $"{dateUser}-{dayOfWeek}.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Date: {dateUser}");
            outputFile.WriteLine(activePrompt);
            outputFile.WriteLine(activeEntry);
        }
    }

    public void showFiles()
    {
        int indexFile = 1;
        string[] txtFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
        
        filesNames = new List<string>();

        foreach (string x in txtFiles)
        {
            Console.WriteLine(indexFile + " - " + Path.GetFileName(x));
            indexFile++;
            filesNames.Add(Path.GetFileName(x));
        }
    }

    public void readFile()
    {
        Console.WriteLine("\nPlease enter the index number of the file that you can read: ");
        Console.Write(">");
        string strIndexNumber = Console.ReadLine();
        int indexNumber = int.Parse(strIndexNumber) - 1;

        string fileIndexName = filesNames[indexNumber]; 
        string[] lines = System.IO.File.ReadAllLines(fileIndexName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
