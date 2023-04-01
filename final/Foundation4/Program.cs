using System;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("dd MMMMM yyyy");

        //Running Activity
        Activity a1 = new Activity();
        Run r1 = new Run("Running", date, 60, 5.0);
        a1._activities.Add(r1);
        r1.GetSummary();

        //Cycling Activity
        Activity a2 = new Activity();
        Cycle c1 = new Cycle("Cycling", date, 120, 15.0);
        a2._activities.Add(c1);
        c1.GetSummary();

        //Swimming Activity
        Activity a3 = new Activity();
        Swim s1 = new Swim("Swimming", date, 45, 50);
        a3._activities.Add(s1);
        s1.GetSummary();
    }
}