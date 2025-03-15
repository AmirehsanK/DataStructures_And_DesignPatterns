namespace DesignPattern.Builder;

public class ConcreteProductBuilder1 : Builder
{
    public override void BuildVar1()
    {
        product.Variable1="ConcreteProduct1.BuildVar1";
    }

    public override void BuildVar2()
    {
        product.Variable1="ConcreteProduct1.BuildVar2";
    }
}