using ConveyorBelts.Domain;
using Logging.Api;
using Messaging.Api;
using Shared.CrossCutting;

namespace ConveyorBelts.Application;

public class InputConveyor : IConveyorBelt
{
    private bool _eStopPressed = false;
    private const string ImagingSensorTopic = "SensorStateChanged3";
    
    public InputConveyor()
    {
        _ = MessageNotifier.Subscribe(ImagingSensorTopic, OnTrayAtImaging);
    }

    private void OnTrayAtImaging(object? obj)
    {
        if (_eStopPressed) return;
        
        Logger.Log("There is a new tray at the input conveyor imaging area.");
    }

    public async Task<OperationResult> GetNextContainer()
    {
        if (_eStopPressed)
        {
            return new OperationResult(false, "Input conveyor is stopped because E-Stop is pressed.");
        }
        
        return new OperationResult(true);
    }

    public async Task<OperationResult> EjectContainer()
    {
        if (_eStopPressed)
        {
            return new OperationResult(false, "Input conveyor is stopped because E-Stop is pressed.");
        }
        
        return new OperationResult(true);
    }

    public async Task<HealthCheckState> GetHealth()
    {
        return HealthCheckState.Healthy;
    }

    public Task OnEStopPressed()
    {
        Logger.Log("E-Stop pressed, stopping input conveyor!");
        _eStopPressed = true;
        return Task.CompletedTask;
    }

    public Task OnEStopReleased()
    {
        Logger.Log("E-Stop released, re-starting input conveyor!");
        _eStopPressed = false;
        return Task.CompletedTask;
    }
}