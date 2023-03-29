using System;

public class SimpleGoal : Goal
{
    private string _type;
    public SimpleGoal (string type, string name, string description, int points, string recordEvent) : base(name, description, points)
    {
       _type = type;
    }

    public override string AddGoal()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", _type + ":",_name,_description,_points,_recordEvent);
    }
}