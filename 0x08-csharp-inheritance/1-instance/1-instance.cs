using System;


class Obj
{
    /// <summary>Method that defines if the object is an instance of, or if the object is an instance of a class that inherited from, Array</summary>
    /// <param name="obj">A Object</param>
    /// <returns>True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return (obj is Array);
    }
}
