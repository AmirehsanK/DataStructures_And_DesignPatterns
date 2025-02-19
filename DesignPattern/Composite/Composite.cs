namespace DesignPattern.Composite;

public class Composite : Component
{
    private List<Component> components = new List<Component>();
    public Composite(string name) : base(name)
    {
    }
    public Composite(string name,Component[] components) : base(name)
    {
        foreach (var item in components)
        {
            Add(item);
        }
    }

    public override void Add(Component component)
    {
        components.Add(component);
    }

    public override void Remove(Component component)
    {
        components.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + name);
        foreach (var item in components)
        {
            item.Display(depth + 2);
        }
    }
}