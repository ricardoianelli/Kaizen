namespace Safety.Api;

public interface IEStopListener
{
    void OnEStopPressed();
    void OnEStopReleased();
}