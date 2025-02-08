namespace DesignPattern.Decorator._1._1;
//Component can be Interface or Class too.
public abstract class Component
{
    public abstract void Operation();
}

public class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("Concrete component.Operation()");
    }
}

