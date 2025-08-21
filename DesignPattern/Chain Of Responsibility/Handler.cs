namespace DesignPattern.Chain_Of_Responsibility;

public abstract class Handler
{
    protected Handler successor;

    public void SetSuccessor(Handler successor)
    {
        this.successor = successor;
    }
    
    public abstract void Handle(int number);
}

public class ConcreteHandler1 : Handler
{
    public override void Handle(int number)
    {
        if (number >= 0 && number < 10)
        {
            Console.WriteLine($"ConcreteHandler1.Handle({number})");
        }
        else if(successor != null)
        {
            successor.Handle(number);
        }
    }
}
public class ConcreteHandler2 : Handler
{
    public override void Handle(int number)
    {
        if (number >= 10 && number < 20)
        {
            Console.WriteLine($"ConcreteHandler2.Handle({number})");
        }
        else if(successor != null)
        {
            successor.Handle(number);
        }
    }
}
public class ConcreteHandler3 : Handler
{
    public override void Handle(int number)
    {
        if (number >= 20 && number < 30)
        {
            Console.WriteLine($"ConcreteHandler3.Handle({number})");
        }
        else if(successor != null)
        {
            successor.Handle(number);
        }
    }
}