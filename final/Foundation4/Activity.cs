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


    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return "";
    }

}