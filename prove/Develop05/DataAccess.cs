using System.Text.Json;


//https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism?pivots=dotnet-7-0


public static class DataAccess
{
    public static void SaveGameFile(GameFile gameFile, string filename="goals.json")
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        string json = JsonSerializer.Serialize(gameFile, options);
        File.WriteAllText(filename, json);
    }

    public static GameFile LoadGameFile(string filename = "goals.json")
    {
        string json =   File.ReadAllText(filename);

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        GameFile gameFile = JsonSerializer.Deserialize<GameFile>(json, options);
        return gameFile;


    }
}