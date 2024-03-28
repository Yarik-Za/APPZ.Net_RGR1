// Інтерфейс, який використовується клієнтом
public interface ITarget
{
    void Request();
}

// Адаптований клас
public class Adaptee
{
    public void SpecificRequest()
    {
        // Варіація: Реалізуйте ваші дії, які потрібно адаптувати
        Console.WriteLine("Adaptee's specific request");
    }
}

// Адаптер, який реалізує інтерфейс ITarget і використовує адаптований клас Adaptee
public class Adapter : ITarget
{
    private readonly Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        // Виклик методу адаптованого класу
        adaptee.SpecificRequest();
    }
}
