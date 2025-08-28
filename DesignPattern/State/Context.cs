namespace DesignPattern.State;

public class Context(State state)
{
    private State _state = state;

    public State State
    {
        get=> _state;
        set
        {
            _state = value;
            Console.WriteLine($"State: {_state.GetType().Name}");
        }
    }
    
    public void Request()
    {
        _state.Handle(this);
    }
    
}