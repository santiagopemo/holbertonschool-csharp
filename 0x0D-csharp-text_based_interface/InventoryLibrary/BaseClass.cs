using System;
using System.Text.Json;


/// <summary>
///  Class BaseClass
/// </summary>
public class BaseClass
{
    /// <summary>
    ///  property id of type string
    /// </summary>
    public string id {get; set;}
    /// <summary>
    ///  property date_created of type DateTime
    /// </summary>
    public DateTime date_created {get; set;}
    /// <summary>
    ///  property date_updated of type DateTime
    /// </summary>
    public DateTime date_updated {get; set;}
    /// <summary>
    ///  BaseClass constructor
    /// </summary>
    public BaseClass()
    {
        id = Guid.NewGuid().ToString();
        date_created = DateTime.Now;
        date_updated = date_created;
    }
    /// <summary>
    ///  Serializes the object
    /// </summary>
    public string ToJSON()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };
        return JsonSerializer.Serialize<Object>(this, options);
    }
    /// <summary>
    ///  Retruns the string representation of this object
    /// </summary>
    public override String ToString()
    {
        string output = $"\x1b[1m[{this.GetType().Name}] ({this.id})\x1b[0m \n{ToJSON()}";
        return output;
    }
}
