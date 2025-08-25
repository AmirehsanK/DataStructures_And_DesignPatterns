namespace DesignPattern.Visitor;

public class ObjectStructure
{
    List<Element> _elements = new List<Element>();

    public void AddElement(Element element)
    {
        _elements.Add(element);
    }

    public void RemoveElement(Element element)
    {
        _elements.Remove(element);
    }

    public void Accept(Visitor visitor)
    {
        foreach (var element in _elements)
        {
            element.Accept(visitor);
        }
    }
}