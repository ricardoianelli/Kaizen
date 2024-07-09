using Kaizen.CrossCutting;

namespace Kaizen.Modules.Scanners.Api;

public interface IBarcodeScanner : IHealthCheckable
{
    Task<string> Read();
    string GetLastBarcodeScanned();
}