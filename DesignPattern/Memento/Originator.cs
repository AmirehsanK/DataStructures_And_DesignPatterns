namespace DesignPattern.Memento;

public class Originator
{
    private string _state;

    public string State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine("Originator current State: " + _state);
        }
    }
    public Memento CreateMemento()
    {
        return new Memento(_state);
    }
    
    public void SetMemento(Memento memento)
    {
        Console.WriteLine("Restoring state from Memento: " + memento.state);
        State = memento.state;
    }
}