namespace DesignPattern.Composite;

public class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
    }

    public override void Add(Component component)
    {
        throw new Exception();
    }

    public override void Remove(Component component)
    {
        throw new Exception();
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + name);
    }
}