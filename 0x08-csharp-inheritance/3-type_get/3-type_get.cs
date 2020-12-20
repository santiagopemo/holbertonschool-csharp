using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

class Obj
{
    /// <summary>Method that prints the names of the available properties and methods of an object</summary>
    /// <param name="myObj">A Object</param>
    public static void Print(object myObj)
    {
        Type myObjType = myObj.GetType();
        TypeInfo info = myObjType.GetTypeInfo();
        IEnumerable<PropertyInfo> pList = info.GetProperties();
        IEnumerable<MethodInfo> mList = info.GetMethods();
        StringBuilder sb = new StringBuilder();

        sb.Append($"{info.Name} Properties:");
        foreach (PropertyInfo property in pList)
            sb.Append($"\n{property.Name}");

        sb.Append($"\n{info.Name} Methods:");
        foreach (MethodInfo method in mList)
            sb.Append($"\n{method.Name}");

        Console.WriteLine(sb.ToString());
    }
}
