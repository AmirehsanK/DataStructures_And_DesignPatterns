namespace DesignPattern.Command;

public abstract class Command
{
    protected Receiver receiver;

    protected Command(Receiver receiver)
    {
        this.receiver = receiver;
    }
    
    public abstract void execute();
}