class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int targetCount, int timesCompleted = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
                return Points + _bonus;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;
    public override string GetStatus() => $"[{(_timesCompleted >= _targetCount ? "X" : " ")}] {Name} -- Completed {_timesCompleted}/{_targetCount}";
    public override string SaveString() => $"ChecklistGoal|{Name}|{Description}|{Points}|{_bonus}|{_targetCount}|{_timesCompleted}";
}