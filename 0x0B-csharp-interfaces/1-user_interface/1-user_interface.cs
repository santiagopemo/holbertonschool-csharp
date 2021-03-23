﻿using System;

///<summary>Base Class</summary>
public abstract class Base
{
    ///<summary>Property name</summary>
    public string name { get; set; }

    ///<summary>Returns the string representation of a Base object</summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}

///<summary>IInteractive Interface</summary>
public interface IInteractive
{
    ///<summary>Delcaration of method Interact</summary>

    void Interact();
}

///<summary>IBreakable Interface</summary>
public interface IBreakable
{
    ///<summary>Delcaration of property durability</summary>
    int durability { get; set; }

    ///<summary>Delcaration of method Break</summary>
    void Break();
}

///<summary>ICollectable Interface</summary>
public interface ICollectable
{
    ///<summary>Delcaration of property isCollected</summary>
    bool isCollected { get; set; }

    ///<summary>Delcaration of method Collect</summary>
    void Collect();
}

///<summary>TestObject Class</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary>Property durability</summary>
    public int durability { get; set;}

    ///<summary>Property isCollected</summary>
    public bool isCollected { get; set; }

    ///<summary>Method Interact with default implementation</summary>
    public void Interact() { }

    ///<summary>Method Break with default implementation</summary>
    public void Break() { }

    ///<summary>Method Collect with default implementation</summary>
    public void Collect() { }
}
