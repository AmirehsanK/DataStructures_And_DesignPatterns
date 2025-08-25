namespace DesignPattern.Visitor;

public abstract class Visitor
{
    public abstract void VisitConcreteElementA(ConcreteElementA item);
    public abstract void VisitConcreteElementB(ConcreteElementB item);
}

public class ConcreteVisitor1 : Visitor
{
    public override void VisitConcreteElementA(ConcreteElementA item)
    {
        Console.WriteLine("CV1: The name is : {0}",item._name);
    }

    public override void VisitConcreteElementB(ConcreteElementB item)
    {
        Console.WriteLine("CV1: The age is : {0}",item._age);
    }
}public class ConcreteVisitor2 : Visitor
{
    public override void VisitConcreteElementA(ConcreteElementA item)
    {
        Console.WriteLine("CV2: The name is : {0}",item._name);
    }

    public override void VisitConcreteElementB(ConcreteElementB item)
    {
        Console.WriteLine("CV2: The age is : {0}",item._age);
    }
}