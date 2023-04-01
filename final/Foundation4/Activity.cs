using System;

public class Activity
{
    protected string _type;
    protected string _date;
    protected int _minutes;
    public List<Activity> _activities = new List<Activity>();

    public Activity()
    {

    }

    public Activity(string type, string date, int minutes) 
    {
        _type = type;
        _date = date;
        _minutes = minutes;
    }
    
    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual void GetSummary()
    {
        foreach (Activity activity in _activities)
        {
            activity.GetSummary();
        }
    }
}