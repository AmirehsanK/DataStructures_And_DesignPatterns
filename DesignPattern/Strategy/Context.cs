namespace DesignPattern.Strategy;

public class Context
{
    private Strategy _strategy;

    public Context(Strategy strategy)
    {
        _strategy = strategy;
    }

    public void Operation()
    {
        Console.WriteLine("Operation running successfully");
        _strategy.Algorithm();
    }
}