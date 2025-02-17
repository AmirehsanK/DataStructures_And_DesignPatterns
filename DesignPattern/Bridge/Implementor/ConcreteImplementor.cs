namespace DesignPattern.Bridge.Implementor;

public class ConcreteImplementor : Implementor
{
    public override void Implementation()
    {
        Console.WriteLine("ConcreteImplementor.Implementation");
    }
}