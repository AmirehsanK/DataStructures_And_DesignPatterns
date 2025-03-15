namespace DesignPattern.Builder;

public abstract class Builder
{
    protected Product product = new();

    public abstract void BuildVar1();
    public abstract void BuildVar2();

    public virtual Product GetResult()
    {
        return product;
    }
}