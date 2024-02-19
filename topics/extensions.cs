// This code is AI generated
using System;

// The Player class
public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
}

// The PlayerExtensions class contains extension methods for the Player class
public static class PlayerExtensions
{
    // The IsAlive method is an extension method for the Player class
    // It checks if the player's health is greater than 0
    public static bool IsAlive(this Player player)
    {
        return player.Health > 0;
    }
}

public class Program
{
    public static void Main()
    {
        // Create a new Player
        Player player = new Player { Name = "John", Health = 100 };

        // Use the IsAlive extension method
        // Even though IsAlive is not a method of the Player class,
        // we can call it as if it were, thanks to the power of extension methods
        bool isAlive = player.IsAlive();  // Returns true

        Console.WriteLine($"Is {player.Name} alive? {isAlive}");
    }
}
