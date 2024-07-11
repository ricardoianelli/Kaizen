using ConveyorBelts.Domain;
using Logging.Api;
using Messaging.Api;
using Sensors.Api;
using Shared.CrossCutting;

namespace ConveyorBelts.Application;

public class InputConveyor : IConveyorBelt
{
    private bool _eStopPressed = false;

    
    public InputConveyor()
    {
        _ = MessageNotifier.Subscribe(Sensors.Api.Topics.ImagingSensorStateChanged, OnImagingSensorChanged);
        _ = MessageNotifier.Subscribe(Safety.Api.Topics.EStopStateChanged, OnEStopChanged);
    }

    private void OnEStopChanged(Message message)
    {
        if (!message.TryUnpack<bool>(out var isPressed)) return;
        
        if (isPressed)
        {
            OnEStopPressed();
            return;
        }

        OnEStopReleased();
    }

    private void OnImagingSensorChanged(Message message)
    {
        if (_eStopPressed || !message.TryUnpack<SensorState>(out var sensorState)) return;

        switch (sensorState)
        {
            case SensorState.On:
                Logger.Log("There is a new tray at the input conveyor imaging area.");
                break;
            case SensorState.Off:
                Logger.Log("A tray has left the input conveyor imaging area.");
                break;
        }
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