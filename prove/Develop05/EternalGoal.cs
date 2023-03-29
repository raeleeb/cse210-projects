using System;

public class EternalGoal : Goal
{
    private string _type;
    public EternalGoal (string type, string name, string description, int points) : base(name, description, points)
    {
       _type = type;
    }

    public override string AddGoal()
    {
        return string.Format("{0}|{1}|{2}|{3}", _type + ":",_name,_description,_points);
    }
}