public class Breathing : Messages
{
    private string _breathIn = "";
    private string _breathOut = "";
    private int _duration = 0;

    public Breathing(string activityName, string activityDescription, string endingMessage, string breathIn, string breathOut) : base(activityName, activityDescription, endingMessage)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
    }

    public string GetBreathIn()
    {
        return _breathIn;
    }

    public string GetBreathOut()
    {
        return _breathOut;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void BreathDuration()
    {
        Console.Write("How long, in seconds, would you like for your session?: ");
        string durationStr = Console.ReadLine();
        _duration = int.Parse(durationStr);

        Console.WriteLine($"Activity duration: {_duration} seconds");
        Thread.Sleep(2000);

        Console.Clear();
    }

    public void BreathingCount()
    {
        int breathingTimes;
        breathingTimes = _duration / 6;

        int breathOutCount = 7;

        for (int j = 0; j < 6; j++)
        {
            if (breathOutCount > 0)
            {
                breathOutCount--;
                Console.Write(breathOutCount);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        //Console.WriteLine();
    }

    public int GetActivityTime()
    {
        int breathingTimes = _duration / 6;
        return breathingTimes;
    }
}

