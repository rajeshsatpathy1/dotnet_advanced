// This code is AI generated
using System;

public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
}

public class Program
{
    public static void Main()
    {
        try
        {
            // Create a new Player
            Player player = new Player { Name = "John", Level = 10 };

            // Use a dynamic object to hold the player
            dynamic dynamicPlayer = player;

            // Access the player's properties using the dynamic object
            Console.WriteLine($"Player Name: {dynamicPlayer.Name}, Level: {dynamicPlayer.Level}");

            // Try to access a property that doesn't exist
            Console.WriteLine($"Player Class: {dynamicPlayer.Class}");
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            // Handle the exception that occurs when trying to access a property that doesn't exist
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

// This demonstrates how dynamic types can be used to write flexible code that bypasses compile-time type checking, and how exception handling can be used to catch and handle errors that occur at runtime