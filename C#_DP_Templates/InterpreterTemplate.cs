// Контекст, в якому виконується інтерпретація
public class Context
{
    // Варіація: Додайте потрібні поля і методи для контексту
}

// Абстрактний вираз
public abstract class AbstractExpression
{
    public abstract void Interpret(Context context);
}

// Конкретний вираз
public class TerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        // Варіація: Реалізуйте інтерпретацію термінального виразу
        Console.WriteLine("Interpreting terminal expression");
    }
}

// Конкретний вираз
public class NonTerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        // Варіація: Реалізуйте інтерпретацію нетермінального виразу
        Console.WriteLine("Interpreting non-terminal expression");
    }
}
