public class ChekListGoal : Goal
{
    private int _bonusPoints;
    private int _repeatCount;
    private int _completeCount;

    public ChekListGoal(string name, string description, int basePoints, int bonusPoints, int repeatCount, int completeCount)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
        _bonusPoints = bonusPoints;
        _repeatCount = repeatCount;
        _completeCount = completeCount;
    }



    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override string ShowGoalProgress()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}