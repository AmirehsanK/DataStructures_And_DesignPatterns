using DesignPattern.Abstract_Factory.Services.ProductA;
using DesignPattern.Abstract_Factory.Services.ProductB;

namespace DesignPattern.Abstract_Factory;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}