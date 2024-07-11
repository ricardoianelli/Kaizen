using Logging.Api;
using Messaging.Api;

namespace Safety.Api;

public static class EStopManager
{
    public const string EStopTopic = "EStop";
    
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
        }
    }

    private static void ToggleEStop()
    {
        _isPressed = !_isPressed;
        _ = MessageNotifier.Publish(EStopTopic, _isPressed);
    }
}