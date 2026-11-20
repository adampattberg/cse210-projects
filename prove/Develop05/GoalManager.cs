using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

public class GoalManager
{
    private List<GoalManager> _goals = new List<Goal>();
    private int _score = 0;

// Runs main menu
    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select a choice from the menu");

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("Invaild choice. Please pick a number from 1 to 6.");
                    break;

            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        string type = Prompt("Which type of goal would you like to create?");

        if (type != "1" && type != "2" && type != "3")
        {
            Console.WriteLine("Invaild goal type.");
            return;
        }

        string name = Prompt("What is the name of your goal? ");
        string description = Prompt("What is a short description of it? ");
        int points = ReadInt("What is the amount of points associated with this goal? ");

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else
        {
            int target = ReadInt("How many times does this goal need to be accomplished for a bonus? ");
            int bonus = ReadInt("What is the bonus for accomplishing it that many times ");
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        ListGoalNames();

        int index = ReadInt("Which goal did you accomplish? ") - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("That is not a valid goal number.");
            return;
        }

        Goal goal = _goals[index];

        if (goal.IsComplete())
        {
            Console.WriteLine{"That goal is already complete, so no points were earned."};
            return;
        }

        int pointsEarned = goal.RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        string filename = Prompt("What is the filename for the goal file?");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        string filename = Prompt("What is the filename for the goal file?");

        if (!File.Exists(filename))
        {
            Console.WriteLine("That file could not be found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            Goal goal = CreateGoalFromString(lines[i]);
            if (goal != null)
            {
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded.");
    }

    private Goal CreateGoalFromString(string line)
    {
        string[] typeAndDetails = line.Split(":", 2);
        string type = typeAndDetails[0];
        string[] parts = typeAndDetails[1].Split("|");

        if (type == "SimpleGoal")
        {
            return new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
        }
        else if (type == "EternalGoal")
        {
            return new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
        }
        else if (type == "ChecklistGoal")
        {
            return new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
        }

        return null;
    }

    private string Prompt(string message)
    {
        Console.Write(message);
        return Console.ReadLine() ?? "";
    }

    private int ReadInt(string message)
    {
        int value;
        Console.Write(message);

        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Please enter a whole number: ");
        }

        return value;
    }
}