public class Cycling : Activity
{
    private float _speed;
    public Cycling(DateOnly date, int duration, float speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return (GetSpeed() * GetDuration())/60;
    }


    public override float GetPace()
    {
        return GetDuration()/GetDistance();
    }

    public override float GetSpeed()
    {
        return _speed;
    }

}