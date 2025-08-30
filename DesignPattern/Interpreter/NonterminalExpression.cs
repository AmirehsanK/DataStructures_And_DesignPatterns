namespace DesignPattern.Interpreter;

public class NonterminalExpression : AbstractExpression
{
    private AbstractExpression _expression1;
    private AbstractExpression _expression2;

    public NonterminalExpression(AbstractExpression expression1, AbstractExpression expression2)
    {
        _expression1 = expression1;
        _expression2 = expression2;
    }

    public override void Interpret(Context context)
    {
        Console.WriteLine("NonterminalExpression");
        _expression1.Interpret(context);
        _expression2.Interpret(context);
    }
}