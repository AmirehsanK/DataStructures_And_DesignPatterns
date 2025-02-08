using DesignPattern.Facade.Package1;
using DesignPattern.Facade.Package2;
using DesignPattern.Facade.Package3;

namespace DesignPattern.Facade;

public class Facade
{
    public void DoSomething()
    {
        var class1 = new Class1();
        var class2 = new Class2();
        var class3 = new Class3();
        
        class1.Run();
        class2.Run();
        class3.Run();
    }
}