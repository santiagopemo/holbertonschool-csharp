using System;

///<summary>Base class</summary>
public abstract class Base
{
    ///<summary>Property name</summary>
    private string name {get; set;}
    ///<summary>String representation of the object</summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}


///<summary>IInteractive interface</summary>
public interface IInteractive
{
    ///<summary>Interact method</summary>
    void Interact();
}
///<summary>IBreakable interface</summary>
public interface IBreakable
{
    ///<summary>durability property</summary>
    int durability {get; set;}
    ///<summary>Break method</summary>
    void Break();
}
///<summary>ICollectable interface</summary>
public interface ICollectable
{
    ///<summary>isCollected property</summary>
    bool isCollected {get; set;}
    ///<summary>Collect method</summary>
    void Collect();
}
///<summary>TestObject Class</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary>durability property</summary>
    public int durability {get; set;}
    ///<summary>isCollected property</summary>
    public bool isCollected {get; set;}
    ///<summary>name property</summary>
    public string name {get; set;}
    ///<summary> Interact Method </summary>
    public void Interact() {} 
    ///<summary>Break Method</summary>
    public void Break() {}   
    ///<summary>Collect Method</summary>
    public void Collect() {}
}
