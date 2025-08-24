namespace DesignPattern.Observer;

public abstract class Subject
{
    private readonly List<Observer> _observers = [];

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

}

public class ConcreteSubject : Subject
{
    private string _subjectState;
    
    public string SubjectState
    {
        get => _subjectState;
        set => _subjectState = value;
    }
}