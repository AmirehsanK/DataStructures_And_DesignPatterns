namespace DesignPattern.Chain_Of_Responsibility;

public class ConcreteHandler1 : Handler
{
    public override void Handle(int number)
    {
        if (number >= 0 && number < 10)
        {
            Console.WriteLine($"ConcreteHandler1.Handle({number})");
        }
        else if(Successor != null)
        {
            Successor.Handle(number);
        }
    }
}