namespace DesignPattern.Command;

public class ConcreteCommand : Command
{
    public ConcreteCommand(Receiver receiver) : base(receiver)
    {
    }

    public override void execute()
    {
        //Logging Section
        receiver.Action();
    }
}