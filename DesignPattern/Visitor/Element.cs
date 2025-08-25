namespace DesignPattern.Visitor;

public abstract class Element
{
public  abstract void Accept(Visitor visitor);
}

public class ConcreteElementA(string name) : Element
{
    public string _name { get; set; } = name;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }
}
public class ConcreteElementB(int age) : Element
{
    public int _age = age;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }
}