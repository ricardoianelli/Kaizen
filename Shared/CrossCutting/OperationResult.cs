namespace Shared.CrossCutting;

public class OperationResult
{
    public readonly bool Success;
    public readonly string Message;

    public OperationResult(bool success, string message)
    {
        Success = success;
        Message = message;
    }
}