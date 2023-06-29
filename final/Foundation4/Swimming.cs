public class Swimming : Activity
{

    private int _laps;

    public Swimming(DateOnly date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override float GetPace()
    {
        return base.GetDuration() / GetDistance();
    }

    public override float GetDistance()
    {
        var distance = _laps * 50;
        return (float)distance / 1000;
    }

    public override float GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }




}