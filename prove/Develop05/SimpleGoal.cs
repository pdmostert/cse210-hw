
public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int basePoints)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _basePoints;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string DisplayGoal()
    {
        if (_isComplete)
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }
}