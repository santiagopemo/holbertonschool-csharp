using System;

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

    /// <summary>Method that Calculates the rectangle's area</summary>
    public new int Area()
    {
        return this.width * this.height;
    }

    /// <summary>Method that returns a string representation of a Rectangle</summary>
    public override string ToString()
    {
        return "[Rectangle] " + this.width + " / " + this.height;
    }
}