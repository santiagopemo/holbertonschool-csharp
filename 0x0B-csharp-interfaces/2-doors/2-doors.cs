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
