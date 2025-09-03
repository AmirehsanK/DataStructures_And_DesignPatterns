using DesignPattern.Abstract_Factory.Services.ProductA;
using DesignPattern.Abstract_Factory.Services.ProductB;

namespace DesignPattern.Abstract_Factory;

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