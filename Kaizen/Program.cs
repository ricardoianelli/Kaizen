namespace Kaizen;

static class Program
{
    public static async Task Main(String[] args)
    {
        ModuleInitializer.Initialize();
        Console.ReadKey();
    }
}