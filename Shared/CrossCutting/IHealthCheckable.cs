namespace Shared.CrossCutting;

public interface IHealthCheckable
{
    Task<HealthCheckState> GetHealth();
}