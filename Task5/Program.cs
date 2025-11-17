
public enum DayType
{
    Weekday,
    Weekend
}

public record Book(string Title, string Author, double Price);

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 5 Enums and Records");

        // Fixed: Handle null input
        Console.Write("Enter day: ");
        string? dayInput = Console.ReadLine();

        if (string.IsNullOrEmpty(dayInput))
        {
            Console.WriteLine("No input provided. Using default: Weekday");
            dayInput = "Monday";
        }

        string lowerDay = dayInput.ToLower();
        DayType daytype = (lowerDay == "friday" || lowerDay == "saturday") 
            ? DayType.Weekend : DayType.Weekday;
        Console.WriteLine($"It is: {daytype}");

        Console.WriteLine();

        // Record usage (unchanged - this part is fine)
        Book book1 = new Book("C# Programming", "Kushal Tamang", 29.99);
        Book book2 = book1 with { Title = "Advanced C#", Price = 49.99 };
        
        Console.WriteLine($"Book1: {book1}");

        var (title, author, price) = book2;
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}