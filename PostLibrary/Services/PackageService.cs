using PostLibrary.Models;
using PostLibrary.Utilities;

namespace PostLibrary.Services;

public class PackageService
{

    public IEnumerable<Box> GetBoxes(string filename)
    {
        return JsonReader.ReadFromFile<Box>(filename);
    }

    public IEnumerable<Envelope> GetEnvelopes(string filename)
    {
        return JsonReader.ReadFromFile<Envelope>(filename);
    }
}