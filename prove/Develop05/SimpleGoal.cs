class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points, bool completed = false)
        : base(name, description, points)
    {
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => _completed;
    public override string GetStatus() => (_completed ? "[X] " : "[ ] ") + Name;
    public override string SaveString() => $"SimpleGoal|{Name}|{Description}|{Points}|{_completed}";
}