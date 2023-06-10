public class EternalGoal : Goal
{
    private int _completeCount;

    public int CompleteCount { get => _completeCount; }

    public EternalGoal(string name, string description, int basePoints, int completeCount)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
        _completeCount = completeCount;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        _completeCount++;
        return _basePoints;
    }

    public override string DisplayGoal()
    {
        return $"[ ] {_name} ({_description}) - Completed {_completeCount} times.";
    }
}