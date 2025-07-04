using System;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public string Name => _name;
    public string Description => _description;
    public int Points => _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string SaveString();
    public static Goal LoadGoal(string saved)
    {
        string[] parts = saved.Split("|");
        switch (parts[0])
        {
            case "SimpleGoal": return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            case "EternalGoal": return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            case "ChecklistGoal": return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
            default: throw new Exception("Unknown goal type.");
        }
    }
}