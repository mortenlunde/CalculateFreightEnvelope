namespace CalculateFreightEnvelope
{
    public static class PackageProcessor
    {
        public static void ProcessPackages(List<Package>? packages, List<Envelopes> envelopeSizes, List<Boxes> boxSizes)
        {
            if (packages == null)
                return;

            foreach (Package package in packages)
            {
                ProcessPackage(package, envelopeSizes, boxSizes);
            }
        }

        private static void ProcessPackage(Package package, List<Envelopes> envelopeSizes, List<Boxes> boxSizes)
        {
            if (package.Dimensions == null)
                return;

            double length = package.Dimensions[0];
            double width = package.Dimensions[1];
            double depth = package.Dimensions[2];

            Envelopes selectedEnvelope = Envelopes.GetEnvelopeSize(length, width, depth, envelopeSizes);
            Boxes selectedBox = Boxes.GetBoxSize(length, width, depth, boxSizes);

            if (selectedEnvelope != null)
            {
                Console.WriteLine($"Produkt: {package.Description}");
                Console.WriteLine($"Passer i konvolutt: {selectedEnvelope.Name}");
                Console.WriteLine($"Pris konvolutt: {selectedEnvelope.Price},-");
                Console.WriteLine($"Pris frakt: {Calculations.CalculateFreight(length, width, depth, package.Weight, selectedEnvelope.AddedWeight)},-");
                Console.WriteLine();
            }
            else if (selectedBox != null)
            {
                Console.WriteLine($"Produkt: {package.Description}");
                Console.WriteLine($"Passer i eske: {selectedBox.Name}");
                Console.WriteLine($"Pris eske: {selectedBox.Price},-");
                Console.WriteLine($"Pris frakt: {Calculations.CalculateFreight(length, width, depth, package.Weight, selectedBox.AddedWeight)},-");
                Console.WriteLine();
            }
        }
    }
}