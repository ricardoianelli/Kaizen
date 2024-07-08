using Kaizen.Common;

namespace Kaizen.Services.Scanners.Interfaces;

public interface IBarcodeScanner : IHealthCheckable
{
    Task<string> Read();
    string GetLastBarcodeScanned();
}