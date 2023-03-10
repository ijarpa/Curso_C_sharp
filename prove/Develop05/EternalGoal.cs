public class EternalGoal : Goal
{
    private int _frequency;

    public int Frequency
    {
        get { return _frequency; }
        set { _frequency = value; }
    }

    public EternalGoal(string checkBox, string name, string description, int points, bool status, int frequency) : base(checkBox, name, description, points, status)
    {
        _frequency = frequency;
    }

    public override void Display()
    {
        Console.WriteLine("Eternal goal:");
        Console.WriteLine($"Name: {GoalName}");
        Console.WriteLine($"Description: {GoalDescription}");
        Console.WriteLine($"Points: {GoalPoints}");
        Console.WriteLine($"Status: {GoalStatus}");
        Console.WriteLine($"Frequency: {_frequency}");
    }

    public void RecordProgress()
    {
        GoalStatus = true; // sets the goal status to true once the progress is recorded
    }
}

