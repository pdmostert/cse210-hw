using System;
/* The Job class contains properties for company, job title, start year, and end year, as well as a
Display function to print out a formatted string. */
public class Job
{

    public string _company { get; set; }
    public string _jobTitle { get; set; }
    public int _startYear { get; set; }
    public int _endYear { get; set; }

/// <summary>
/// The Display function prints out a formatted string containing job title, company, and start/end
/// years.
/// </summary>
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}