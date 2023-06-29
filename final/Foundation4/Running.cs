public class Running : Activity
{
    private float _distance;

    public Running(DateOnly date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public override float GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }




}