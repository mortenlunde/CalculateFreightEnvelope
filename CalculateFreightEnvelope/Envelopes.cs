using Newtonsoft.Json;

namespace CalculateFreightEnvelope;

public class Envelopes()
{
    public string? Name { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public double Weight { get; set; }
    public double Price { get; set; }

    
    
    public static List<Envelopes> LoadEnvelopeSizes(string jsonFile)
    {
        using StreamReader r = new(jsonFile);
        string json = r.ReadToEnd();
        return JsonConvert.DeserializeObject<List<Envelopes>>(json) ?? throw new InvalidOperationException();
    }
    
    public static Envelopes GetEnvelopeSize(double length, double width, double depth, double weight, List<Envelopes> sizes)
    {
        foreach (var envelope in sizes)
        {
            if (length <= envelope.Length &&
                width <= envelope.Width &&
                depth <= envelope.Depth &&
                weight <= envelope.Weight)
            {
                return envelope;
            }
        }
        return null; // No suitable envelope found
    }
}