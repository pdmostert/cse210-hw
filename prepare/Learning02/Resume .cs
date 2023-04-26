using System;
/* The Resume class contains a name and a list of jobs, and has a Display function to print them. */
public class Resume
{
    public string _name { get; set; }
    public List<Job> _jobs { get; set; } = new();

/// <summary>
/// The Display function prints the name and jobs of an object.
/// </summary>
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}