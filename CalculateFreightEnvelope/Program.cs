using CalculateFreightEnvelope;

AppSettings appSettings = AppConfig.Config();

List<Envelopes> envelopeSizes = Envelopes.LoadEnvelopeSizes(appSettings.EnvelopesJson);
List<Boxes> boxSizes = Boxes.LoadBoxSizes(appSettings.BoxesJson);

Package.PackageData? packageData = Items.LoadPackageData(appSettings.ItemsJson);

PackageProcessor.ProcessPackages(packageData.Packages, envelopeSizes, boxSizes);