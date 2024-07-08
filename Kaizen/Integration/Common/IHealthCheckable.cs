namespace Kaizen.Integration.Common;

public interface IHealthCheckable
{
    Task<HealthCheckState> GetHealth();
}