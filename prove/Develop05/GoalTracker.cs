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

    public void UpdateGoal(int index, bool status, string gtype)
    {
        var goal = _goalsList[index];
        goal.GoalStatus = status;
        goal.GoalType = gtype;

        if (status == true && gtype == "1")
        {
            goal.GoalCheckBox = "[x]";
            _userScore += goal.GoalPoints;
        }
        else if (status == false && gtype == "1")
        {
            goal.GoalCheckBox = "[ ]";
            _userScore -= goal.GoalPoints;
        }
        else if (status == true && gtype == "2")
        {
            goal.GoalCheckBox = "[ ]";
            _userScore += goal.GoalPoints;
        }
        else
        {
            Console.WriteLine("Error, check again the Index/Status/Goal Type");
        }
    }


    public void ShowGoals()
    {
        Console.WriteLine("List of Goals:");
        int index = 1; // Inicializamos el índice en 1
        foreach (Goal data in _goalsList)
        {
            Console.Write($"{index}. "); // Imprimimos el índice antes de los datos
            data.Display(); // Imprimimos los datos de la meta
            index++; // Incrementamos el índice en 1
        }
        Console.WriteLine();
    }

    public void ShowScore()
    {
        Console.WriteLine(_userScore);
    }


    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goalsList)
            {
                writer.WriteLine($"{goal.GoalName},{goal.GoalDescription},{goal.GoalPoints},{goal.GoalStatus}");
                //else if (goal is ChecklistGoal)
                //{
                //    writer.WriteLine($"{((ChecklistGoal)goal).GoalTarget},{((ChecklistGoal)goal).GoalCompleted}");
                //}
            }
        }
    }

    //public void LoadGoals(string fileName)
    //{
    //    using (StreamReader reader = new StreamReader(fileName))
    //    {
    //        while (!reader.EndOfStream)
    //        {
    //            string[] goalData = reader.ReadLine().Split(',');
    //            switch (goalData[0])
    //            {
    //                case "SimpleGoal":
    //                    AddGoal(new SimpleGoal(goalData[1], goalData[2], goalData[3], goalData[4], int.Parse(goalData[5]), bool.Parse(goalData[6])));
    //                    break;
    //                case "EternalGoal":
    //                    AddGoal(new EternalGoal(goalData[1], goalData[2], goalData[3], goalData[4], int.Parse(goalData[5]), bool.Parse(goalData[6]), int.Parse(reader.ReadLine())));
    //                    break;
    //                //case "ChecklistGoal":
    //                //    string[] checklistData = reader.ReadLine().Split(',');
    //                //    AddGoal(new ChecklistGoal(goalData[1], goalData[2], goalData[3], int.Parse(goalData[4]), bool.Parse(goalData[5]), int.Parse(checklistData[0]))
    //                //    {
    //                //        GoalCompleted = int.Parse(checklistData[1])
    //                //    });
    //                //    break;
    //            }
    //        }
    //    }
    //}
}
