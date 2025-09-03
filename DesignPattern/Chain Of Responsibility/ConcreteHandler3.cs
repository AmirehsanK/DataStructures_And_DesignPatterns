namespace DesignPattern.Chain_Of_Responsibility;

public class ConcreteHandler3 : Handler
{
    public override void Handle(int number)
    {
        if (number >= 20 && number < 30)
        {
            Console.WriteLine($"ConcreteHandler3.Handle({number})");
        }
        else if(Successor != null)
        {
            Successor.Handle(number);
        }
    }
}