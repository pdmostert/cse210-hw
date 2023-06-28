public class Cycling : Activity
{
    private double _speed;
    public Cycling(DateOnly date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
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