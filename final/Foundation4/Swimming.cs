public class Swimming : Activity
{

    private int _laps;

    public Swimming(DateOnly date, int duration, int laps):base(date,duration)
    {
        _laps = laps;
    }

    public override double GetPace()
    {
        throw new NotImplementedException();
    }

    public override double GetDistance()
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