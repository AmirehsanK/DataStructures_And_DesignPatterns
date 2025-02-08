namespace DesignPattern.Decorator._1._1;
/// <summary>
/// Called Decorator or Wrapper
/// Used to add feature to methods that you don't want to change
/// </summary>
public abstract class Decorator(Component component) : Component
{
    public override void Operation()
    {
        component.Operation();
        //if you want to add just one feature you can write your code here and not add ConcreteDecorator
    }
}

public class ConcreteDecorator(Component component) : Decorator(component)
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("Concrete decorator.Operation()");
    }
}
public class ConcreteDecorator2(Component component) : Decorator(component)
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("Concrete decorator2.Operation()");
    }
}