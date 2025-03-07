namespace DesignPattern.Prototype;
//Deep Copy
public class ConcretePrototype2 : IPrototype
{
    public string Subject { get; set; }
    public ConcretePrototype1 Data { get; set; }

    public ConcretePrototype2()
    {
        Data = new ConcretePrototype1();
    }
    public IPrototype Clone()
    {
        var clone = (ConcretePrototype2)MemberwiseClone();
        clone.Data=(ConcretePrototype1)Data.Clone();
        return clone;
    }
}