public class SharedResource
{
    private int counter = 0;
    private readonly object lockObject = new object();

    // Метод, що використовує блокування для безпечного збільшення лічильника
    public void Increment()
    {
        lock (lockObject)
        {
            // Варіація: Додайте вашу логіку збільшення лічильника
            counter++;
        }
    }

    // Метод для отримання поточного значення лічильника
    public int GetValue()
    {
        lock (lockObject)
        {
            return counter;
        }
    }
}
