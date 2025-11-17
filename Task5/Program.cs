// Enumm Defination
public enum DayType
{
    Weekday,
    Weekend,
}
// record the defination
public record Book(string Title, string Author, double Price);

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 5 Enums and Records");

//Enum usage
        Console.Write("Enter day: ");
        string dayInput = Console.ReadLine();

//check if weekend or weekday
        DayType daytype = (dayInput.ToLower() == "friday" || dayInput.ToLower() == "saturday")
            ? DayType.Weekend
            : DayType.Weekday;

//Record usage
        Book book1 = new Book("C# Programming", "Kushal Tamang", 29.99);

//Create new record with changes
        Book book2 = book1 with { Title = "Advanced C#", Price = 49.99 };
        Console.WriteLine($"Book1: {book1}");

//Deconstruct record
        var (title, author, price) = book2;
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}

    