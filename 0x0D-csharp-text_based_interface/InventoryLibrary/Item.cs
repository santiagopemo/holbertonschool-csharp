using System;
using System.Collections.Generic;


/// <summary>
///  Class Item
/// </summary>
public class Item : BaseClass
{
    /// <summary>
    ///  property name of type string
    /// </summary>
    public string name {get; set;}
    /// <summary>
    ///  property description of type string
    /// </summary>
    public string description {get; set;}
    // private field _price
    private float _price;
    /// <summary>
    ///  property price of type float limited to two decimal points
    /// </summary>
    public float price {
        get { return _price; } 
        set {
            // _price = (float)Math.Round(value * 100f) / 100f;
            _price = (float)Math.Round(value, 2);
            // _price = (float)(Math.Truncate((double)value * 100.0) / 100.0);
        }
    }
    /// <summary>
    ///  property tags of type List of strings
    /// </summary>
    public List<string> tags {get; set;}
    /// <summary>
    ///  Item class constructor
    /// </summary>
    public Item()
    {
        this.name = "Item";
    }
    /// <summary>
    ///  Item class constructor
    /// </summary>
    public Item(string name = "Item")
    {
        this.name = name;
    }
}
