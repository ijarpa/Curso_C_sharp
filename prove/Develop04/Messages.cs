public class Messages
{
    //Atributes
    private string _activityName;
    private string _activityDescription;
    private string _endingMessage;

    public Messages(string activityName, string activityDescription, string endingMessage)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _endingMessage = endingMessage;
    }

    public string GetName()
    {
        return _activityName;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }


    public void Loading()
    {
        int x = 0;
        while (x < 3) //duration 6 seconds
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            x++;
        }
    }

}