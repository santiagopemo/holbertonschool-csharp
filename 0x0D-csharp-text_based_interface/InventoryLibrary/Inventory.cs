using System;


/// <summary>
///  Class Inventory
/// </summary>
public class Inventory : BaseClass
{
    /// <summary>
    ///  property user_id of type string
    /// </summary>
    public string user_id  {get; set;}
    /// <summary>
    ///  property item_id of type string
    /// </summary>
    public string item_id  {get; set;}
    // private field _quantity of type int
    private int _quantity;
    /// <summary>
    ///  property quantity of type int cant be lesss than 0
    /// </summary>
    public int quantity {
        get { return _quantity; }
        set { _quantity = value < 0 ? 0 : value; }
    }
    /// <summary>
    ///  User class constructor
    /// </summary>
    public Inventory()
    {
        this.user_id = "Inventory_u_id";
        this.item_id = "Inventory_i_id";
        this.quantity = 1;
    }
    /// <summary>
    ///  User class constructor
    /// </summary>
    public Inventory(string user_id = "Inventory_u_id", string item_id = "Inventory_i_id", int quantity = 1)
    {
        this.user_id = user_id;
        this.item_id = item_id;
        this.quantity = quantity;
    }
}
