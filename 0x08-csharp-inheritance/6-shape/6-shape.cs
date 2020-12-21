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

/// <summary>Defines a Rectangle Shape</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Property Width, Sets or Gets the value of width field</summary>
    public int Width
    {
        get
        {
            return this.width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            this.width = value;
        }
    }
    /// <summary>Property Height, Sets or Gets the value of heigt field</summary>
    public int Height
    {
        get
        {
            return this.height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            this.height = value;
        }
    }
}
