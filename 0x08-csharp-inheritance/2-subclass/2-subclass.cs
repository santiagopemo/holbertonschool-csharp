using System;

class Obj
{
    /// <summary>Method that defines if the object is an instance of a class that inherits from the specified class</summary>
    /// <param name="derivedType">A Type</param>
    /// <param name="baseType">A Type</param>
    /// <returns>True if derivedType is an instance of a class that inherits from baseType, otherwise False</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
