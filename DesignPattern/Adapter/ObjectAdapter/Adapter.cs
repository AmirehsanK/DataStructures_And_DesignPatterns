namespace DesignPattern.Adapter.ObjectAdapter;

public class Adapter : Target
{
    private readonly Adaptee _adaptee = new();

    public override void Operation()
    {
        _adaptee.Operation();
    }
}