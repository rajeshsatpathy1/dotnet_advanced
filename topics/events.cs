// This code is AI generated
using System;

public class Player
{
    public event Action<int> OnHealthDecrease;

    private int health;

    public void IncreaseHealth(int amount)
    {
        health += amount;
    }

    public void DecreaseHealth(int amount)
    {
        if (health >= amount)
        {
            health -= amount;
            if (OnHealthDecrease != null)  // Traditional null check
            {
                OnHealthDecrease(amount);
            }
        }
        else
        {
            throw new InvalidOperationException("Health is already at zero");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Player player = new Player();
            player.OnHealthDecrease += amount => Console.WriteLine("Player's health decreased by {0}", amount);

            player.IncreaseHealth(100);
            player.DecreaseHealth(50);  // This will trigger the event
            player.DecreaseHealth(60);  // This will throw an exception
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

// In this code, Player is a class that has an event OnHealthDecrease. This event is triggered whenever the player’s
//  health decreases. The Program class subscribes to this event and prints a message whenever it’s triggered.

// The try-catch block in the Main method is used to handle exceptions. If a decrease in health is attempted 
// that would take the player’s health below zero, an InvalidOperationException is thrown, and the catch block 
// catches this exception and prints an error message.