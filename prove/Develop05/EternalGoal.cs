public class EternalGoal : Goal
{

    public EternalGoal(string checkBox, string name, string description, int points, bool status)
        : base(checkBox, name, description, points, status)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"{GoalCheckBox} - {GoalName} - {GoalDescription} - {GoalPoints} points - {GoalStatus}");
    }

    public void RecordProgress()
    {
        GoalStatus = true; // sets the goal status to true once the progress is recorded
    }
}

