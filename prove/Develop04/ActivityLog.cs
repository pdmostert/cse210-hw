using System;
public class ActivityLog
{
    private string _date;
    private string _activity;

    public ActivityLog(string activity)
    {
        _activity = activity;
        _date = DateTime.Now.ToShortDateString();
    }

    public ActivityLog(string date, string activity)
    {
        _date = date;
        _activity = activity;
    }

/// <summary>
/// The function returns a string that concatenates the date and activity with a delimiter.
/// This is used as output for the FileSave function
/// </summary>
/// <returns>
/// A string that concatenates the `_date` and `_activity` fields with the separator `~|~`.
/// </returns>
    public string RenderActivityLog()
    {
        return $"{_date}~|~{_activity}";
    }
    

/// <summary>
/// The function returns a string that displays the date and activity log.
/// This function is usefull for output to the user.
/// </summary>
/// <returns>
/// A string that displays the date and activity log. The date and activity are stored in private
/// variables and are being accessed through the use of placeholders in the string.
/// </returns>
    public string DisplayActivityLog(){
        return $"Date: {_date}, {_activity}";
    }


}