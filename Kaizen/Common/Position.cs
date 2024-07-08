namespace Kaizen.Common;

public class Position
{
    public decimal X;
    public decimal Y;

    public Position(decimal x, decimal y)
    {
        X = x;
        Y = y;
    }
    
    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}