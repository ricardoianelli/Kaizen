using Kaizen.Integration.Common;

namespace Kaizen.Integration.Scanners;

public interface IBarcodeScanner : IHealthCheckable
{
    Task<string> Read();
    string GetLastBarcodeScanned();
}