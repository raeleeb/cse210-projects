using System;

public class ChecklistGoal : Goal
{
    private string _type;
    private int _checkCount;
    private int _bonusPoints;
    private int _check = 0;
    public ChecklistGoal (string type, string name, string description, int points, string recordEvent) : base(name, description, points)
    {
       _type = type;
    }

    public ChecklistGoal(string type)
    {
        _type = type;
    }

    public override string AddGoal()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", _type + ":",_name,_description,_points,_recordEvent,_check,_checkCount,_bonusPoints);
    }

    public override void GoalDetails()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        _name = goalName;

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        _description = goalDescription;

        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();
        int points = (int.Parse(goalPoints));
        _points = points;

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string checkCount = Console.ReadLine();
        int check = (int.Parse(checkCount));
        _checkCount = check;

        Console.Write("What is the bonus for accomplishing it that many time? ");
        string bonusPoints = Console.ReadLine();
        int bonus = (int.Parse(bonusPoints));
        _bonusPoints = bonus;
    }
}