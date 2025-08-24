namespace DesignPattern.Observer;

public abstract class Observer
{
    public abstract void Update();
}

public class ConcreteObserver(ConcreteSubject subject, string name) : Observer
{
    private string _observerState;
    private ConcreteSubject _subject = subject;

    public override void Update()
    {
        _observerState=_subject.SubjectState;
        Console.WriteLine("Observer {0} received message: {1}", name, _observerState);
    }

    public ConcreteSubject Subject
    {
        get => _subject;
        set => _subject = value;
    }
}