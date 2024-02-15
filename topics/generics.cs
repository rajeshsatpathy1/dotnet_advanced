// This code is AI generated
using System;
using System.Collections.Generic;

public class Player
{
    public string Name { get; set; }
}

public class Enemy
{
    public string Type { get; set; }
}

public class Item
{
    public string Name { get; set; }
}

public class GameObjectList<T>
{
    private List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public T Get(int index)
    {
        return list[index];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GameObjectList<Player> playerList = new GameObjectList<Player>();
        playerList.Add(new Player { Name = "Player1" });

        GameObjectList<Enemy> enemyList = new GameObjectList<Enemy>();
        enemyList.Add(new Enemy { Type = "Enemy1" });

        GameObjectList<Item> itemList = new GameObjectList<Item>();
        itemList.Add(new Item { Name = "Item1" });

        Console.WriteLine("Player: " + playerList.Get(0).Name);
        Console.WriteLine("Enemy: " + enemyList.Get(0).Type);
        Console.WriteLine("Item: " + itemList.Get(0).Name);
    }
}

// This program creates lists of Player, Enemy, and Item objects, adds an object to each list,
// and then prints the name or type of the first object in each list. You should see the names 
// “Player1”, “Enemy1”, and “Item1” printed to the console when you run this program.