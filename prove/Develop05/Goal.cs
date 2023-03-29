using System;
using System.Linq;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected List<string> _goals = new List<string>();
    protected string _recordEvent = "False";
    private int _totalPoints = 0;

    public Goal ()
    {

    }

    public Goal (string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SetTotalPoints(int totalPoints)
    {
        totalPoints += _totalPoints;
    }

    public void CreateNewGoal()
    {
        int userInput = 0;

        while (userInput != -1)
        {
            try
            {
                Console.WriteLine("\nThe types of Goals are: ");
                Console.WriteLine("\t1. Simple Goal");
                Console.WriteLine("\t2. Eternal Goal");
                Console.WriteLine("\t3. Checklist Goal");
                Console.Write("\nWhich type of goal would you like to create? ");

                string userSelection = Console.ReadLine();
                userInput = int.Parse(userSelection); 

                if (userInput == 1)
                {
                    GoalDetails();
                    SimpleGoal g1 = new SimpleGoal("SimpleGoal", _name, _description, _points, _recordEvent);
                    _goals.Add(g1.AddGoal());
                    break;

                }
                else if (userInput == 2)
                {
                    GoalDetails();
                    EternalGoal g2 = new EternalGoal("EternalGoal", _name, _description, _points);
                    _goals.Add(g2.AddGoal());
                    break;
                }
                else if (userInput == 3)
                {
                    ChecklistGoal g3 = new ChecklistGoal("ChecklistGoal");
                    g3.GoalDetails();
                    _goals.Add(g3.AddGoal());
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid number - select a valid number and press enter.");
                }
            }
            catch (FormatException) 
            {
               Console.WriteLine("\nInvalid - enter a number from the menu."); 
            }
        }
    }

    public virtual void GoalDetails()
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
    }

    public virtual string AddGoal()
    {
        return "";
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string[] strGoal = _goals[i].Split("|");
            if (strGoal[0] == "SimpleGoal:")
            {
                if (strGoal[4] == "False")
                {
                    Console.WriteLine($"{i+1}. [ ] {strGoal[1]} ({strGoal[2]})");
                }
                else
                {
                    Console.WriteLine($"{i+1}. [x] {strGoal[1]} ({strGoal[2]})");
                }
            }
            else if (strGoal[0] == "EternalGoal:")
            {
                Console.WriteLine($"{i+1}. [ ] {strGoal[1]} ({strGoal[2]})");
            }
            else if (strGoal[0] == "ChecklistGoal:")
            {
                if (strGoal[4] == "False")
                {
                    Console.WriteLine($"{i+1}. [ ] {strGoal[1]} ({strGoal[2]}) -- Currently completed: {strGoal[5]}/{strGoal[6]}");
                }
                else
                {
                    Console.WriteLine($"{i+1}. [x] {strGoal[1]} ({strGoal[2]}) -- Currently completed: {strGoal[6]}/{strGoal[6]}");
                }
            }
        }
    }

    public int RecordEvent()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string[] strGoal = _goals[i].Split("|");
            if (strGoal[0] == "SimpleGoal:")
            {
                if (strGoal[4] == "False")
                {
                    Console.WriteLine($"{i+1}. {strGoal[1]}");
                }
                else
                {
                    Console.WriteLine($"{i+1}. {strGoal[1]} --complete");
                }
            }
            else if (strGoal[0] == "EternalGoal:")
            {
                Console.WriteLine($"{i+1}. {strGoal[1]}");
            }
            else if (strGoal[0] == "ChecklistGoal:")
            {
                if (strGoal[4] == "False")
                {
                    Console.WriteLine($"{i+1}. {strGoal[1]}");
                }
                else
                {
                    Console.WriteLine($"{i+1}. {strGoal[1]} --complete");
                }
            }
        }

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been set. Returning to the main menu.");
            return _totalPoints;   
        }
        
        while (_goals.Count != 0)
        {
            try
            {
                int userInput;
                Console.Write("\nWhich goal did you accomplish? ");
                string input = Console.ReadLine();
                userInput = int.Parse(input);
                int index = userInput - 1;

                string recordDetails = _goals[index];
                string[] details = recordDetails.Split("|");

                if (details[0] == "SimpleGoal:")
                {
                    string type = details[0];
                    string name = details[1];
                    string description = details[2];
                    string points = details[3];
                    
                    string add = string.Format("{0}|{1}|{2}|{3}|{4}", type,name,description,points,"True");
                    _goals[index] = add;
                }
                else if (details[0] == "ChecklistGoal:")
                {
                    string type = details[0];
                    string name = details[1];
                    string description = details[2];
                    string points = details[3];
                    string recordEvent = details[4];
                    string check = details[5];
                    int checkNum = int.Parse(check);
                    string checkCount = details[6];
                    int checkCountNum = int.Parse(checkCount);
                    string bonusPoints = details[7];
                    int bonus = int.Parse(bonusPoints);
                    
                    if ((checkNum + 1) == checkCountNum)
                    {
                        string add = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", type,name,description,points,"True",check,checkCount,bonusPoints);
                        _goals[index] = add;
                        _totalPoints += bonus;
                        Console.WriteLine($"*** Congratulations! You have earned {bonus} bonus points! ***");
                    }
                    else
                    {
                        string add = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", type,name,description,points,recordEvent,checkNum+1,checkCount,bonusPoints);
                        _goals[index] = add;
                    }         
                }
                    
                string num = details[3];
                int number = int.Parse(num);
                _totalPoints += number;
                Console.WriteLine($"Congratulations! You have earned {number} points!");
                break;
            }
            catch (ArgumentOutOfRangeException) 
            {
               Console.WriteLine("\nInvalid - enter a number and press enter."); 
            }
        }

        return _totalPoints;   
    }
        



    public void SaveToFile()
    {
        Console.Write("Please enter the file name without .txt extension: ");
        string userFile = Console.ReadLine();
        userFile = userFile + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFile))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (string goal in _goals)
            {
                outputFile.WriteLine(goal);
            }     
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Please enter the saved file name without .txt extension: ");
        string userFile = Console.ReadLine();
        userFile = userFile + ".txt";

        try
        {
        string fileName = userFile;
        string line1 = File.ReadLines(fileName).First();
        int totalPoints = int.Parse(line1);
        _totalPoints = totalPoints;

        string[] lines = System.IO.File.ReadAllLines(fileName);
        lines = lines.Skip(1).ToArray();
        
            foreach (string line in lines)
            {
                _goals.Add(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("\nFile doesn't exist, try again.");
        }   
    }
}