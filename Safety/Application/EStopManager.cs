using Logging.Api;
using Messaging.Api;
using Safety.Api;

namespace Safety.Application;

internal static class EStopManager
{
    internal const int EStopCheckingDelayInMs = 1000;
    
    private static bool _isPressed;
    
    static EStopManager()
    {
        _isPressed = false;
    }

    internal static void Initialize()
    {
        _ = CheckEStop();
    }
    
    private static async Task CheckEStop()
    {
        while (true)
        {
            try
            {
                var random = new Random();
                if (random.Next(0, 10) == 1)
                {
                    ToggleEStop();
                }    
            }
            catch (Exception e)
            {
                Logger.Log(e.Message);
            }

            await Task.Delay(EStopCheckingDelayInMs);
        }
    }

    private static void ToggleEStop()
    {
        Logger.Log("Toggle EStop!");
        _isPressed = !_isPressed;
        _ = MessageNotifier.Publish(Safety.Api.Topics.EStopStateChanged, _isPressed);
    }
}