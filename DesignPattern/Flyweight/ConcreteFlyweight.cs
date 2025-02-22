namespace DesignPattern.Flyweight;

public class ConcreteFlyweight(string intrinsicState) : FlyWeight
{
    private readonly string _intrinsicState = intrinsicState;

    public override void Operation(string extrinsicState)
    {
        Console.WriteLine($"{_intrinsicState}: {extrinsicState}");
    }
}