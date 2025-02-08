namespace DesignPattern.Decorator._1._2;

public class SmsSenderDecorator(SmsSender smsSender) : SmsSender
{
    public void Send()
    {
        base.Send();
        Console.WriteLine("SendSmsDecorator.Send()");
    }
    
}