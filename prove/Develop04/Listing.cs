public class Listing : Messages
{
    private string _startPrompt = "";
    private int _duration = 0;

    public Listing(string activityName, string activityDescription, string endingMessage, string startPrompt) : base(activityName, activityDescription, endingMessage)
    {
        _startPrompt = startPrompt;
    }

    public string GetStartPrompt()
    {
        return _startPrompt;
    }

    public void ListingDuration()
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
        int reflectCount = 6;

        for (int j = 0; j < 5; j++)
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

    public int GetActivityTime()
    {
        int activityDuration = _duration;
        return activityDuration;
    }
}