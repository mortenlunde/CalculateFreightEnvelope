using Newtonsoft.Json;

namespace CalculateFreightEnvelope;

public record Boxes(string? Name, int Length, int Width, int Depth, double Price, double AddedWeight)
{
    public readonly string? Name = Name;
    public readonly int Length = Length;
    public readonly int Width = Width;
    public readonly int Depth = Depth;
    public readonly double Price = Price;
    public readonly double AddedWeight = AddedWeight;
    
    public static List<Boxes> LoadBoxSizes(string jsonFile)
    {
        using StreamReader r = new(jsonFile);
        string json = r.ReadToEnd();
        return JsonConvert.DeserializeObject<List<Boxes>>(json) ?? throw new InvalidOperationException();
    }
    
    public static Boxes GetBoxSize(double length, double width, double depth, List<Boxes> sizes)
    {
        foreach (Boxes boxes in sizes)
        {
            if (length <= boxes.Length &&
                width <= boxes.Width &&
                depth <= boxes.Depth)
            {
                return boxes;
            }
        }
        return null; // No suitable envelope found
    }
}