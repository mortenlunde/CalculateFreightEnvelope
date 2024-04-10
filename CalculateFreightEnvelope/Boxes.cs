using Newtonsoft.Json;

namespace CalculateFreightEnvelope;

public record Boxes(string? Name, int Length, int Width, int Depth, double MaxWeight, double Price)
{
    public readonly string? Name = Name;
    public readonly int Length = Length;
    public readonly int Width = Width;
    public readonly int Depth = Depth;
    public readonly double MaxWeight = MaxWeight;
    public readonly double Price = Price;
    
    
    public static List<Boxes> LoadBoxSizes(string jsonFile)
    {
        using StreamReader r = new(jsonFile);
        string json = r.ReadToEnd();
        return JsonConvert.DeserializeObject<List<Boxes>>(json) ?? throw new InvalidOperationException();
    }
    
    public static Boxes GetBoxSize(double length, double width, double depth, double max_weight, List<Boxes> sizes)
    {
        foreach (Boxes boxes in sizes)
        {
            if (length <= boxes.Length &&
                width <= boxes.Width &&
                depth <= boxes.Depth &&
                max_weight <= boxes.MaxWeight)
            {
                return boxes;
            }
        }
        return null; // No suitable envelope found
    }
}