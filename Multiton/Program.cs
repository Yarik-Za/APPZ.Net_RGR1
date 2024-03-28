using System;
using System.Collections.Generic;

public class Multiton
{
    private static readonly Dictionary<string, Multiton> instances = new Dictionary<string, Multiton>();

    private Multiton() { }

    public static Multiton GetInstance(string key)
    {
        if (!instances.ContainsKey(key))
        {
            instances[key] = new Multiton();
        }
        return instances[key];
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Використання Multiton
        Multiton instance1 = Multiton.GetInstance("key1");
        Multiton instance2 = Multiton.GetInstance("key2");
        Multiton instance3 = Multiton.GetInstance("key1");
        Multiton instance4 = Multiton.GetInstance("кеу1");

        Console.WriteLine(instance1.GetHashCode()); // Виведе хеш першого екземпляру
        Console.WriteLine(instance2.GetHashCode()); // Виведе хеш другого екземпляру
        Console.WriteLine(instance3.GetHashCode()); // Виведе такий же хеш, як у першого екземпляру (тобто він вже створений)
        Console.WriteLine(instance4.GetHashCode());

        Console.ReadKey();
    }
}
