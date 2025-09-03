namespace DesignPattern.Chain_Of_Responsibility;

public class ConcreteHandler2 : Handler
{
    public override void Handle(int number)
    {
        if (number >= 10 && number < 20)
        {
            Console.WriteLine($"ConcreteHandler2.Handle({number})");
        }
        else if(Successor != null)
        {
            Successor.Handle(number);
        }
    }
}