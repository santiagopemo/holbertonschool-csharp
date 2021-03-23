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
