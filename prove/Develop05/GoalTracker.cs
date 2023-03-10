using System;
using System.IO;

class GoalTracker
{
    private List<Goal> _goalsList;
    private int _userScore;

    public GoalTracker()
    {
        _goalsList = new List<Goal>();
    }

    public void AddGoal(Goal data)
    {
        _goalsList.Add(data);
    }

    public void UpdateGoal(int index, bool status)
    {
        var goal = _goalsList[index];
        goal.GoalStatus = status;

        if (status == true)
        {
            goal.GoalCheckBox = "[x]";
            _userScore += goal.GoalPoints;
        }
        else
        {
            goal.GoalCheckBox = "[ ]";
            _userScore -= goal.GoalPoints;
        }
    }


    public void ShowGoals()
    {
        Console.WriteLine("List of Goals:");
        foreach (Goal data in _goalsList)
        {
            data.Display();
        }
    }
    public int ShowScore()
    {
        return _userScore;
    }


    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goalsList)
            {
                writer.WriteLine($"{goal.GoalName},{goal.GoalDescription},{goal.GoalPoints},{goal.GoalStatus}");
                if (goal is EternalGoal)
                {
                    writer.WriteLine(((EternalGoal)goal).Frequency);
                }
                //else if (goal is ChecklistGoal)
                //{
                //    writer.WriteLine($"{((ChecklistGoal)goal).GoalTarget},{((ChecklistGoal)goal).GoalCompleted}");
                //}
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string[] goalData = reader.ReadLine().Split(',');
                switch (goalData[0])
                {
                    case "SimpleGoal":
                        AddGoal(new SimpleGoal(goalData[1], goalData[2], goalData[3], int.Parse(goalData[4]), bool.Parse(goalData[5])));
                        break;
                    case "EternalGoal":
                        AddGoal(new EternalGoal(goalData[1], goalData[2], goalData[3], int.Parse(goalData[4]), bool.Parse(goalData[5]), int.Parse(reader.ReadLine())));
                        break;
                    //case "ChecklistGoal":
                    //    string[] checklistData = reader.ReadLine().Split(',');
                    //    AddGoal(new ChecklistGoal(goalData[1], goalData[2], goalData[3], int.Parse(goalData[4]), bool.Parse(goalData[5]), int.Parse(checklistData[0]))
                    //    {
                    //        GoalCompleted = int.Parse(checklistData[1])
                    //    });
                    //    break;
                }
            }
        }
    }
}
