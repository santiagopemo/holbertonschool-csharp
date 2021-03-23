using System;

///<summary>Base Class</summary>
abstract class Base
{
    ///<summary>Property name</summary>
    public string name { set; get; }

    ///<summary>Returns the string representation of a Base object</summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}

///<summary>IInteractive Interface</summary>
interface IInteractive
{
    ///<summary>Delcaration of method Interact</summary>

    void Interact();
}

///<summary>IBreakable Interface</summary>
interface IBreakable
{
    ///<summary>Delcaration of property durability</summary>
    int durability { set; get; }

    ///<summary>Delcaration of method Break</summary>
    void Break();
}

///<summary>ICollectable Interface</summary>
interface ICollectable
{
    ///<summary>Delcaration of property isCollected</summary>
    bool isCollected { set; get; }

    ///<summary>Delcaration of method Collect</summary>
    void Collect();
}



///<summary>Door Class</summary>
class Door : Base, IInteractive
{
    ///<summary>Base Constructor</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    ///<summary>Method Interact</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

class Decoration : Base, IInteractive, IBreakable 
{
    public bool isQuestItem;

    public int durability { get; set; }

    public Decoration (string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        if (durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        if (durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}

class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (isCollected)
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }
        else
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
    }
}
