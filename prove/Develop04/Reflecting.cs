public class Reflecting : Messages
{
    private string _startPrompt = "";
    private int _duration = 0;

    public Reflecting(string activityName, string activityDescription, string endingMessage, string startPrompt) : base(activityName, activityDescription, endingMessage)
    {
        _startPrompt = startPrompt;
    }

    public string GetStartPrompt()
    {
        return _startPrompt;
    }

    public void ReflectDuration()
    {
        Console.Write("How long, in seconds, would you like for your session?: ");
        string durationStr = Console.ReadLine();
        _duration = int.Parse(durationStr);

        Console.WriteLine($"Activity duration: {_duration} seconds");
        Thread.Sleep(2000);

        Console.Clear();
    }
    public void CountLoading()
    {
        int reflectCount = 4;

        for (int j = 0; j < 3; j++)
        {
            if (reflectCount > 0)
            {
                reflectCount--;
                Console.Write(reflectCount);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
    public void ReflectCount()
    {
        int reflectTime;
        reflectTime = _duration / 2; //because are 2 questions

        int reflectCount = reflectTime;

        for (int j = 0; j < reflectTime; j++)
        {
            if (reflectCount > 0)
            {
                reflectCount--;
                Console.Write(reflectCount);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}