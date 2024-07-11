using Messaging.Api;

namespace Logging.Api;

public static class Logger
{
    static Logger()
    {
        _ = MessageNotifier.Subscribe(Messaging.Api.Topics.Global, OnNewMessage);
    }

    public static void Log(string msg)
    {
        Console.WriteLine("New Log: " + msg);
    }

    private static void OnNewMessage(Message msg)
    {
        Console.WriteLine("New Message: " + msg);
    }
}