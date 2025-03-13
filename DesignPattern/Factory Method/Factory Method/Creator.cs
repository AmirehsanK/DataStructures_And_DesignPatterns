using DesignPattern.Factory_Method.User;

namespace DesignPattern.Factory_Method.Factory_Method;

public abstract class Creator
{
    public abstract IUserService GetInstance(int x);
}