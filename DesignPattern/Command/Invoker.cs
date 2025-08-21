namespace DesignPattern.Command;

public class Invoker
{
    private Command _command;

    public void setCommand(Command command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.execute();
    }
}