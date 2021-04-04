using System;


/// <summary>
///  Class User
/// </summary>
public class User : BaseClass
{
    /// <summary>
    ///  property name of type string
    /// </summary>
    public string name {get; set;}
        /// <summary>
    ///  User class constructor
    /// </summary>
    public User()
    {
        this.name = "User";
    }
    /// <summary>
    ///  User class constructor
    /// </summary>
    public User(string name = "User")
    {
        this.name = name;
    }
}
