namespace DesignPattern.Mediator;

public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}

public class ConcreteMediator : Mediator
{
    ConcreteColleagueA _colleagueA;
    ConcreteColleagueB _colleagueB;

    public ConcreteColleagueA ColleagueA
    {
        set { _colleagueA = value; }
    }
    public ConcreteColleagueB ColleagueB
    {
        set { _colleagueB = value; }
    }
    public override void Send(string message, Colleague colleague)
    {
        if (colleague==_colleagueA)
        {
            _colleagueB.Notify(message);
        }
        else if (colleague == _colleagueB)
        {
            _colleagueA.Notify(message);
        }
    }
}