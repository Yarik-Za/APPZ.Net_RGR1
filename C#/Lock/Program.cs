using System;
using System.Threading;

public class SharedResource
{
    private int _counter = 0;
    private readonly object _lockObject = new object();

    public void Increment()
    {
        lock (_lockObject)
        {
            _counter++;
        }
    }

    public int GetValue()
    {
        lock (_lockObject)
        {
            return _counter;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SharedResource resource = new SharedResource();

        // Створюємо два потоки, які збільшують значення ресурсу
        Thread thread1 = new Thread(() =>
        {
            for (int i = 0; i < 10000; i++)
            {
                resource.Increment();
            }
        });

        Thread thread2 = new Thread(() =>
        {
            for (int i = 0; i < 10000; i++)
            {
                resource.Increment();
            }
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Final value: " + resource.GetValue());

        Console.ReadKey();
    }
}
