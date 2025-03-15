namespace DesignPattern.Builder;

public class Director
{
    private Builder _builder;

    public void SetProductBuilder(Builder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildVar1();
        _builder.BuildVar2();
    }
}