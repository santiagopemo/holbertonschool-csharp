using System;

/// <summary>
/// Enum Modifier
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak
    /// </summary>
    Weak,
    /// <summary>
    /// Base
    /// </summary>
    Base,
    /// <summary>
    /// Strong
    /// </summary>
    Strong
}
/// <summary>
/// Delegate CalculateMdifier
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
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
    // Player's status
    private string status;
    /// <summary>
    /// delegate CalculateHealth that takes a float amount
    /// </summary>
    public delegate void CalculateHealth(float amount);
    /// <summary>
    /// Event handler of type CurrentHPArgs
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;
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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
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
        ValidateHP(this.hp - damage);
    }
    /// <summary>
    /// Prints the heal received
    /// </summary>
    public void HealDamage(float heal)
    {
        heal = heal < 0 ? 0 : heal;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        ValidateHP(this.hp + heal);
    }

    /// <summary>
    /// Set the players health
    /// </summary>
    public void ValidateHP(float newHp)
    {
        this.hp = (newHp < 0 ? 0 : (newHp > maxHp ? maxHp : newHp));
        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }
    /// <summary>
    /// Applies a modifier to a base value
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak) return (baseValue / 2.0f);
        if (modifier == Modifier.Strong) return (baseValue * 1.5f);
        return baseValue;
    }
    // Method to check the status
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            Console.WriteLine($"{this.name} is in perfect health!");
        if (e.currentHp >= (maxHp / 2.0f) && e.currentHp < maxHp)
            Console.WriteLine($"{this.name} is doing well!");
        if (e.currentHp >= (maxHp / 4.0f) && e.currentHp < (maxHp / 2.0f))
            Console.WriteLine($"{this.name} isn't doing too great...");
        if (e.currentHp > 0f && e.currentHp < (maxHp / 4.9f))
            Console.WriteLine($"{this.name} needs help!");
        if (e.currentHp == 0f)
            Console.WriteLine($"{this.name} is knocked out!");
    }
}
/// <summary>
/// Class CurrentHPArgs
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Current healt points, cannot be modified
    /// </summary>
    public readonly float currentHp;
    /// <summary>
    /// CurrentHPArgs constructor
    /// </summary>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}
