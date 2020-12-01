using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int last_digit = Math.Abs(number % 10);
        Console.Write(last_digit);
        return last_digit;
    }
}
