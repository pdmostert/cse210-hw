public static class DataAccess
{
        public static List<Scripture> LoadFile(string fileName = "Scriptures.txt")
    {
        List<Scripture> scriptures = new();
        string[] lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            string[] parts = line.Split("~|~");
            string[] referenceParts = parts[0].Split(",");
            Reference reference = new(referenceParts[0],int.Parse(referenceParts[1]),int.Parse(referenceParts[2]),int.Parse(referenceParts[3]));

            scriptures.Add(new Scripture(reference,parts[1]));
        }
        return scriptures;
    }

    public static void SaveFile(List<Scripture> scriptures, string fileName = "Scriptures.txt")
    {
        using StreamWriter outputfile = new StreamWriter(fileName);
        foreach (var scripture in scriptures)
        {
            outputfile.WriteLine($"{scripture.CreateFileString()}");
        }
    }
}