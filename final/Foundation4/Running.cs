public class Running : Activity
{
    private double _distance;

    public Running(DateOnly date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        throw new NotImplementedException();
    }

    public override double GetPace()
    {
        throw new NotImplementedException();
    }

    public override double GetSpeed()
    {
        throw new NotImplementedException();
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }


}