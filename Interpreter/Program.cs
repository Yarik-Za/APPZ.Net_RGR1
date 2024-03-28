using System;
using System.Linq;

public interface IExpression
{
    int Interpret();
}

public class NumberExpression : IExpression
{
    private int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public int Interpret()
    {
        return _number;
    }
}

public class AddExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public AddExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret()
    {
        return _left.Interpret() + _right.Interpret();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Використання інтерпретатора
        IExpression expression = new AddExpression(new NumberExpression(10), new NumberExpression(5));
        Console.WriteLine(expression.Interpret()); // Результат: 15

        Console.ReadKey();
    }
}
