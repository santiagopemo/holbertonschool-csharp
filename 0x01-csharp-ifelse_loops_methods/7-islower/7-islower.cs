using System;

class Character
{       
    public static bool IsLower(char c)
    {
        if ( c <= 'z' && c >= 'a')
            return true;
        else
            return false;
    }
}
