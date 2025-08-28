namespace DesignPattern.Iterator;

public class ConcreteAggregate : Aggregate
{
    private List<object> items = [];
    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }
    public int Count => items.Count;

    public object this[int index]
    {
        get => items[index];
        set => items.Insert(index,value);
    }
}