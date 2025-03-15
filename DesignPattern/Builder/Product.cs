namespace DesignPattern.Builder;

public class Product
{
    public string Variable1 { get; set; }
    public string Variable2 { get; set; }

    public void Show()
    {
        Console.WriteLine("Product variable 1: {0} - Product variable 2: {1}", Variable1,Variable2);
    }
}