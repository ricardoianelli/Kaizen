using Shared.CrossCutting;

namespace Scanners.Api;

public interface IBarcodeScanner : IHealthCheckable
{
    Task<string> Read();
    string GetLastBarcodeScanned();
}