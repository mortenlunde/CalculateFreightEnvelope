namespace CalculateFreightEnvelope;

public class Package
{
    public string? Description { get; set; }
    public List<int>? Dimensions { get; set; } = null;
    public double Weight { get; set; }
    
    public class PackageData
    {
        public string Info { get; set; } = string.Empty;
        public List<Package>? Packages { get; set; } = null;
    }
}