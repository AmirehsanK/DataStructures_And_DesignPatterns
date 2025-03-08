namespace DesignPattern.Singleton;

public class Singelton
{
    private static Singelton instance=new Singelton();

    private Singelton(){}

    public static Singelton GetInstance()
    {
        return instance;
    }
}