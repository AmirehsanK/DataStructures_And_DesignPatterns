namespace DesignPattern.Prototype;
//Shallow Copy
public class ConcretePrototype1 : IPrototype
{
    public int Id { get; set; }

    public string Title { get; set; }
    public IPrototype Clone()
    {
        return (ConcretePrototype1)this.MemberwiseClone();
    }
}