public class Player
{
    public String playerName;
    public int level;
    public int health;
    
    // Default Constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
        
    }
    
    // Parameterized constructor
    public Player(String name, int level, int health)
    {
        playerName = name;
        level = level;
        health = health;

    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{playerName}");
        Console.WriteLine($"Level:{level}");
        Console.WriteLine($"Health:{health}");
    }
}