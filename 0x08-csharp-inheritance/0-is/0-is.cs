using System;


class Obj
{
    /// <summary>Method that returns True if the object is an int, otherwise return False</summary>
    /// <param name="obj">A Object</param>
    /// <returns>True if the object is an int, otherwise return False</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj.GetType() == typeof(int));
    }
}
