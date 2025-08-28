namespace DesignPattern.Iterator;

public class ConcreteIterator : Iterator
{
    public ConcreteAggregate aggregate;
    private int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public override object First()
    {
        return aggregate[0];
    }

    public override object Next()
    {
        object ret = null!;
        current++;
        if (current < aggregate.Count)
        {
            ret = aggregate[current];
        }

        return ret;
    }

    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }

    public override object CurrentItem()
    {
        return aggregate[current];
    }
}
    