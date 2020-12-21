using System;

/// <summary>Defines a shape</summary>
class Shape
{
    /// <summary>Virtual method throws a </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
