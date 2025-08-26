namespace DesignPattern.Mediator;

public abstract class Colleague
{
    protected Mediator _mediator;
    protected Colleague(Mediator mediator)
    {
        _mediator = mediator;
    }
}
public class ConcreteColleagueA : Colleague
{
    public ConcreteColleagueA(Mediator mediator) : base(mediator)
    {
    }
    public void Notify(string message)
    {
        Console.WriteLine($"ConcreteColleagueA sends message: {message}");
    }
    public void Send(string message)
    {
        _mediator.Send(message, this);
    }
}

public class ConcreteColleagueB : Colleague
{
    public ConcreteColleagueB(Mediator mediator) : base(mediator)
    {
    }
    public void Notify(string message)
    {
        Console.WriteLine($"ConcreteColleagueB sends message: {message}");
    }
    public void Send(string message)
    {
        _mediator.Send(message, this);
    }
}