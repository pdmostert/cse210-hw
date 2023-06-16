public class CheckListGoal : Goal
{
    private int _bonusPoints;
    private int _repeatCount;
    private int _completedCount;

    public int BonusPoints { get => _bonusPoints; }
    public int RepeatCount { get => _repeatCount; }
    public int CompletedCount { get => _completedCount; }


    public CheckListGoal(string name, string description, int basePoints, int bonusPoints, int repeatCount, int completedCount) : base(name, description, basePoints)
    {
        // _name = name;
        // _description = description;
        // _basePoints = basePoints;
        _bonusPoints = bonusPoints;
        _repeatCount = repeatCount;
        _completedCount = completedCount;
    }




    public override bool IsComplete()
    {
        if (_completedCount >= _repeatCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int RecordEvent()
    {
        _completedCount++;
        if (IsComplete())
        {
            return BasePoints + _bonusPoints;
        }
        else
        {
            return BasePoints;
        }

    }

    public override string DisplayGoal()
    {
        if (IsComplete())
        {
            return $"[X] {Name} ({Description}) -- Currently completed: {_completedCount}/ {_repeatCount} times.";
        }
        else
        {
            return $"[ ] {Name} ({Description}) -- Currently completed: {_completedCount}/ {_repeatCount} times.";
        }
    }


}