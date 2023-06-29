public abstract class Event
{
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;

    public Event(string title, string description, DateOnly date, TimeOnly time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    protected string GetTitle()
    {
        return _title;
    }
    protected DateOnly GetDate()
    {
        return _date;
    }

    public string GenerateStandardDescription()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address.RenderAddress()}";
    }

    public abstract string GenerateShortDescription();
    public abstract string GenerateFullDescription();


}