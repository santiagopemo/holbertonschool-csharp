using System;

/// <summary>Base class</summary>
public abstract class Base
{
    /// <summary>Name property</summary>
    public string name { get; set; }

    /// <summary>String representation of a Base object</summary>
    /// <returns>A string</returns>
    public override string ToString() => $"{name} is a {GetType().Name}";
}

/// <summary>Interactive interface</summary>
public interface IInteractive
{
    /// <summary>Interact method</summary>
    void Interact();
}

/// <summary>Breackable interface</summary>
public interface IBreakable
{
    /// <summary>Durability property</summary>
    int durability { get; set; }

    /// <summary>Break method</summary>
    void Break();
}

/// <summary>Collectable interface</summary>
public interface ICollectable
{
    /// <summary>IsCollected Property</summary>
    bool isCollected { get; set; }

    /// <summary>Collect method</summary>
    void Collect();
}

/// <summary>TestObject class</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>Interact method</summary>
    public void Interact() { }

    /// <summary>Durability property</summary>
    public int durability { get; set; }

    /// <summary>Break method</summary>
    public void Break() { }

    /// <summary>IsCollected Property</summary>
    public bool isCollected { get; set; }

    /// <summary>Collect method</summary>
    public void Collect() { }
}
