using Newtonsoft.Json;

namespace CalculateFreightEnvelope;

public static class Items
{
    public static Package.PackageData? LoadPackageData(string? itemsJsonPath)
    {
        string json;
        using (StreamReader sr = new StreamReader(itemsJsonPath))
        {
            json = sr.ReadToEnd();
        }
        return JsonConvert.DeserializeObject<Package.PackageData>(json);
    }
}