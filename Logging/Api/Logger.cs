using Messaging.Api;

namespace Logging.Api;

public static class Logger
{
    static Logger()
    {
        _ = MessageNotifier.Subscribe("global", OnNewMessage);
    }

    public static void Log(string msg)
    {
        Console.WriteLine("New Log: " + msg);
    }

    private static void OnNewMessage(object? msg)
    {
        Console.WriteLine("New Message: " + msg);
    }
}