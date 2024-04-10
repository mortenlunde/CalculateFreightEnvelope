using System.Text.Json;

namespace PostLibrary.Utilities;

public class JsonReader
{
    public static IEnumerable<T> ReadFromFile<T>(string filename)
        where T : class
    {
        if (!File.Exists(filename))
            throw new FileNotFoundException($"Finner ikke fil {filename}");

        var jsonString = File.ReadAllText(filename);
        Console.WriteLine(jsonString); // Feilsøking: Skriv ut JSON-strengen

        var items = JsonSerializer.Deserialize<IEnumerable<T>>(jsonString);

        return items ?? new List<T>();
    }
    
}