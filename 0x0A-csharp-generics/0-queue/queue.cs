using System;

///<summary>Queue Class</summary>
class Queue<T>
{
    ///<summary>Returns the Queue’s type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
