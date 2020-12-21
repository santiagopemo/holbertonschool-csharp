using System;

/// <summary>Defines a shape</summary>
class Shape
{
    /// <summary>Virtual method that Calculates a area</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}