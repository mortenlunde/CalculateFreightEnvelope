using Newtonsoft.Json;

namespace CalculateFreightEnvelope;

public record Envelopes(string? Name, int Length, int Width, int Depth, double MaxWeight, double Price)
{
    public readonly string? Name = Name;
    public readonly int Length = Length;
    public readonly int Width = Width;
    public readonly int Depth = Depth;
    public readonly double MaxWeight = MaxWeight;
    public readonly double Price = Price;
    
    
    public static List<Envelopes> LoadEnvelopeSizes(string jsonFile)
    {
        using StreamReader r = new(jsonFile);
        string json = r.ReadToEnd();
        return JsonConvert.DeserializeObject<List<Envelopes>>(json) ?? throw new InvalidOperationException();
    }
    
    public static Envelopes GetEnvelopeSize(double length, double width, double depth, double max_weight, List<Envelopes> sizes)
    {
        foreach (Envelopes envelope in sizes)
        {
            if (length <= envelope.Length &&
                width <= envelope.Width &&
                depth <= envelope.Depth &&
                max_weight <= envelope.MaxWeight)
            {
                return envelope;
            }
        }
        return null; // No suitable envelope found
    }
}