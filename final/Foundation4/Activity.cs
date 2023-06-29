public abstract class Activity
{

    private DateOnly _date;
    private int _duration;

    public Activity(DateOnly date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    protected int GetDuration()
    {
        return _duration;
    }
    protected DateOnly GetDate()
    {
        return _date;
    }


    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} {this.GetType()} ({GetDuration()} min): Distance: {string.Format("{0:0.0}", GetDistance())} km, Speed: {string.Format("{0:0.0}", GetSpeed())} kph, Pace: {string.Format("{0:0.0}", GetPace())} min per km)";
    }

}