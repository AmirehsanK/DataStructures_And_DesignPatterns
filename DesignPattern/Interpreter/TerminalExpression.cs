namespace DesignPattern.Interpreter;

public class TerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        Console.WriteLine("TerminalExpression");
    }
}