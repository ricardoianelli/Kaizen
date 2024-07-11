namespace Messaging.Api;

public class BrokerConnectionParams
{
    public string Host;
    public string UserName;
    public string Password;
    public int Port;

    public BrokerConnectionParams(string host, int port, string userName, string password)
    {
        Host = host;
        UserName = userName;
        Password = password;
        Port = port;
    }
}