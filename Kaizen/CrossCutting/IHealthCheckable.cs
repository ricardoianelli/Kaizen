namespace Kaizen.CrossCutting;

public interface IHealthCheckable
{
    Task<HealthCheckState> GetHealth();
}