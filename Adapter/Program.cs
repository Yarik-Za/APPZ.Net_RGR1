using System;

public interface IDateParser
{
    DateTime ParseDate(string dateString);
}

public class DateAdapter : IDateParser
{
    public DateTime ParseDate(string dateString)
    {
        return DateTime.ParseExact(dateString, "yyyy-MM-dd", null);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Використання адаптера
        IDateParser dateParser = new DateAdapter();
        DateTime parsedDate = dateParser.ParseDate("2024-03-28");

        Console.WriteLine(parsedDate);

        Console.ReadKey();
    }
}
