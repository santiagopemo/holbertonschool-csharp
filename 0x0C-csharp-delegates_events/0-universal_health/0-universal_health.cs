using System;

/// <summary>
/// Class Player
/// </summary>
class Player
{
    /// Player's name    
    private string name;    
    /// Player's max health amount    
    private float maxHp;    
    /// Player's health amount    
    private float hp;
    /// <summary>
    /// Player's constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        hp = maxHp;
    }
    /// <summary>
    /// Method that prints the players health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
