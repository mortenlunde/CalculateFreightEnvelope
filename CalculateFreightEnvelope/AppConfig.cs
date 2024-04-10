using Microsoft.Extensions.Configuration;

namespace CalculateFreightEnvelope
{
    public static class AppConfig
    {
        public static AppSettings Config()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("AppSettings.json")
                .Build();

            string itemsJson = configuration["ItemsJSON"] ?? throw new ArgumentException("Missing ItemsJSON file path in AppSettings.json");
            string envelopesJson = configuration["EnvelopesJSON"] ?? throw new ArgumentException("Missing EnvelopesJSON file path in AppSettings.json");
            string boxesJson = configuration["BoxesJSON"] ?? throw new ArgumentException("Missing BoxesJSON file path in AppSettings.json");

            return new AppSettings
            {
                ItemsJson = itemsJson,
                EnvelopesJson = envelopesJson,
                BoxesJson = boxesJson
            };
        }
    }

    public class AppSettings
    {
        public string? ItemsJson { get; init; }
        public string? EnvelopesJson { get; init; }
        public string? BoxesJson { get; init; }
    }
}