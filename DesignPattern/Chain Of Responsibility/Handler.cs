namespace DesignPattern.Chain_Of_Responsibility;

public abstract class Handler
{
    protected Handler Successor;

    public void SetSuccessor(Handler successor)
    {
        this.Successor = successor;
    }
    
    public abstract void Handle(int number);
}