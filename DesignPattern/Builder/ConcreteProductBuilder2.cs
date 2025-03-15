namespace DesignPattern.Builder;

public class ConcreteProductBuilder2 : Builder
{
    public override void BuildVar1()
    {
        product.Variable1="ConcreteProduct2.BuildVar1";
    }

    public override void BuildVar2()
    {
        product.Variable1="ConcreteProduct2.BuildVar2";
    }
}