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

        string itemsJson = configuration["ItemsJSON"] ?? throw new ArgumentException("Missing ItemsJSON file path in AppSettings.json");

        string envelopesJson = configuration["EnvelopesJSON"] ?? throw new ArgumentException("Missing EnvelopesJSON file path in AppSettings.json");
        string boxesJson = configuration["BoxesJSON"] ?? throw new ArgumentException("Missing BoxesJSON file path in AppSettings.json");

        List<Envelopes> envelopeSizes = Envelopes.LoadEnvelopeSizes(envelopesJson);
        List<Boxes> boxSizes = Boxes.LoadBoxSizes(boxesJson);

        string json;
        using (StreamReader sr = new(itemsJson))
        {
            json = sr.ReadToEnd();
        }
        PackageData? packageData = JsonConvert.DeserializeObject<PackageData>(json);

        // Iterate through each package and find the appropriate envelope size
        if (packageData == null) return;
        if (packageData.Packages == null) return;
        foreach (Package package in packageData.Packages)
        {
            if (package.Dimensions == null) continue;
            double length = package.Dimensions[0];
            double width = package.Dimensions[1];
            double depth = package.Dimensions[2];

            Envelopes selectedEnvelope =
                Envelopes.GetEnvelopeSize(length, width, depth, envelopeSizes);
            Boxes selectedBox =
                Boxes.GetBoxSize(length, width, depth, boxSizes);

            

            if (selectedEnvelope != null)
            {
                Console.WriteLine($"Produkt: {package.Description}");
                Console.WriteLine($"Passer i konvolutt: {selectedEnvelope.Name}");
                Console.WriteLine($"Pris konvolutt: {selectedEnvelope.Price},-");
                Console.WriteLine($"Pris frakt: {Calculations.CalculateFreight(package.Dimensions[0], package.Dimensions[1], package.Dimensions[2], package.Weight).ToString()},-");
                Console.WriteLine();
            }
            else
            {
                if (selectedBox != null)
                {
                    Console.WriteLine($"Produkt: {package.Description}");
                    Console.WriteLine($"Passer i eske: {selectedBox.Name}");
                    Console.WriteLine($"Pris eske: {selectedBox.Price},-");
                    Console.WriteLine($"Pris frakt: {Calculations.CalculateFreight(package.Dimensions[0], package.Dimensions[1], package.Dimensions[2], package.Weight).ToString()},-");
                    Console.WriteLine();
                }
            }
        }
    }
}