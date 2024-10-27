public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int Bonus => _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetStringRepresentation() =>
        $"{_shortName} (Checklist Goal): Completed {_amountCompleted}/{_target} - {_description}";

    public override string GetDetailsString()
    {
        var pointsDisplay = IsComplete() ? $"{_points + _bonus}" : $"{_points}";
        return $"{base.GetDetailsString()} - Target: {_target} - Bonus: {_bonus} - Current Points: {pointsDisplay}";
    }
}