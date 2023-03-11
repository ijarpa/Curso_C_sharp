public class SimpleGoal : Goal
{
    public SimpleGoal(string checkBox, string name, string description, int points, bool status) 
        : base(checkBox, name, description, points, status)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"{GoalCheckBox} - {GoalName} - {GoalDescription} - {GoalPoints} points - {GoalStatus}");
    }
}