namespace Kaizen.Common;

public interface IHealthCheckable
{
    Task<HealthCheckState> GetHealth();
}