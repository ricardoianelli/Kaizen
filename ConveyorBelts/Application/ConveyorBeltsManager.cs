using ConveyorBelts.Domain;

namespace ConveyorBelts.Application;

internal static class ConveyorBeltsManager
{
    internal static IConveyorBelt InputConveyor;

    static ConveyorBeltsManager()
    {
        InputConveyor = new InputConveyor();
    }
    
    public static void Initialize()
    {
    }
}