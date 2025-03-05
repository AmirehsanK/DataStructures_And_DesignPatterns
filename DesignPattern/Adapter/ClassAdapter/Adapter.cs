namespace DesignPattern.Adapter.ClassAdapter;

public class Adapter : ClassAdapter.Adaptee,ITarget 
{
    public void Operation()
    {
        AdapteeOperation();
    }
}