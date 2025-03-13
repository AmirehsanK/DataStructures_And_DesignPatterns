using DesignPattern.Factory_Method.User;

namespace DesignPattern.Factory_Method.Factory_Method;

public abstract class Creator
{
    public abstract IUserService GetInstance(int x);
}
public class ConcreteCreator : Creator
{
    public override IUserService GetInstance(int x)
    {
        return x switch
        {
            0 => new ConcreteUserService1(),
            > 0 => new ConcreteUserService2(),
            _ => new ConcreteUserService1()
        };
    }
}