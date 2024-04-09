using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CalculateFreightEnvelope;

public class PackageData
{
    public string Info { get; set; } = string.Empty;
    public List<Package>? Packages { get; set; } = null;
}

public class Package
{
    public string? Description { get; set; }
    public List<int>? Dimensions { get; set; } = null;
    public double Weight { get; set; }
}

class Program
{
    private static void Main()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("AppSettings.json")
            .Build();

        string jsonFile = configuration["EnvelopesJSON"] ?? throw new ArgumentException("Missing EnvelopesJSON file path in AppSettings.json");
        string itemsJson = configuration["ItemsJSON"] ?? throw new ArgumentException("Missing ItemsJSON file path in AppSettings.json");

        List<Envelopes> envelopeSizes = Envelopes.LoadEnvelopeSizes(jsonFile);

        string json;
        using (StreamReader sr = new StreamReader(itemsJson))
        {
            json = sr.ReadToEnd();
        }
        PackageData? packageData = JsonConvert.DeserializeObject<PackageData>(json);

        // Iterate through each package and find the appropriate envelope size
        if (packageData != null)
            foreach (Package package in packageData.Packages)
            {
                double length = package.Dimensions[0];
                double width = package.Dimensions[1];
                double depth = package.Dimensions[2];
                double weight = package.Weight;

                Envelopes selectedEnvelope = Envelopes.GetEnvelopeSize(length, width, depth, weight, envelopeSizes);

                if (selectedEnvelope != null)
                {
                    Console.WriteLine($"Package: {package.Description}");
                    Console.WriteLine($"Selected envelope size: {selectedEnvelope.Name}");
                    Console.WriteLine($"Price: {selectedEnvelope.Price}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"No suitable envelope found for package: {package.Description}");
                }
            }
    }
}