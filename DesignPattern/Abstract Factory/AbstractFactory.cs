using DesignPattern.Abstract_Factory.Services.ProductA;
using DesignPattern.Abstract_Factory.Services.ProductB;

namespace DesignPattern.Abstract_Factory;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

public class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}
public class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}