using System;
using System.Collections.Generic;
using System.IO;
public class DataAccess
{
    public static List<ActivityLog> LoadFile(string fileName = "ActivityLog.txt")
    {
        List<ActivityLog> actvities = new();
        string[] lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            string[] parts = line.Split("~|~");
            string date = parts[0];
            string activity = parts[1];

            ActivityLog activityLog = new(date, activity);
            actvities.Add(activityLog);
        }
        return actvities;
    }

    public static void SaveFile(ActivityLog activity, string fileName = "ActivityLog.txt")
    {
        using StreamWriter outputfile = new StreamWriter(fileName, true); // true is for append only
        outputfile.WriteLine($"{activity.RenderActivityLog()}");
    }



}