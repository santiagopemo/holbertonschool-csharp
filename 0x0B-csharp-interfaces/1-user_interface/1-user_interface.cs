using System;

///<summary>Base class</summary>
public abstract class Base
{
    ///<summary>Property name</summary>
    private string name {get; set;}
    ///<summary>String representation of the object</summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
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
    ///<summary> overrider </summary>
    void Break();
}
///<summary> overrider </summary>
public interface ICollectable
{
    ///<summary> overrider </summary>
    /// <value>Getter and setter</value>
    bool isCollected {get; set;}
    ///<summary> overrider </summary>
    void Collect();
}
///<summary> overrider </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary> overrider </summary>
    /// <value>Getter and setter</value>
    public int durability {get; set;}
    ///<summary> overrider </summary>
    /// <value>Getter and setter</value>
    public bool isCollected {get; set;}
    ///<summary>  override </summary>
    public string name {get; set;}
    ///<summary> overrider </summary>
    public void Interact() {} 
    ///<summary> overrider </summary>
    public void Break() {}   
    ///<summary> overrider </summary>
    public void Collect() {}
}
