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
    /// delegate CalculateHealth that takes a float amount
    /// </summary>
    public delegate void CalculateHealth(float amount);
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
    /// <summary>
    /// Prints the damage received
    /// </summary>
    public void TakeDamage(float damage)
    {
        damage = damage < 0 ? 0 : damage;
        Console.WriteLine($"{this.name} takes {damage} damage!");
    }
    /// <summary>
    /// Prints the heal received
    /// </summary>
    public void HealDamage(float heal)
    {
        heal = heal < 0 ? 0 : heal;
        Console.WriteLine($"{this.name} heals {heal} HP!");
    }
}
