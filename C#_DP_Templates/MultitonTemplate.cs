public class Multiton
{
    private static readonly Dictionary<string, Multiton> instances = new Dictionary<string, Multiton>();

    // Приватний конструктор, щоб не допустити створення екземплярів ззовні
    private Multiton() { }

    // Метод для отримання екземпляру за ключем
    public static Multiton GetInstance(string key)
    {
        if (!instances.ContainsKey(key))
        {
            // Варіація: Замініть цей рядок створення екземпляру на вашу реалізацію
            instances[key] = new Multiton();
        }
        return instances[key];
    }
}
