using System;

/// <summary>Defines a Square Rectangle</summary>
class Square : Rectangle
{
    private int size;

    /// <summary>Property Size, Sets or Gets the value of size field</summary>
    public int Size
    {
        get 
        {
            return this.size;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            this.size = this.Width = this.Height = value;
        }        
    }

    /// <summary>Method that returns a string representation of a Square</summary>
    public override string ToString()
    {
        return "[Square] " + this.size + " / " + this.size;
    }
}
