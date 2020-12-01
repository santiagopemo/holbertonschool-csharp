using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last_digit = number % 10;
        string output = "The last digit of " + number + " is " + last_digit; 

        if (last_digit > 5)
            output += " and is greater than 5";
        else if (last_digit == 0)
            output += " and is 0";
        else if (last_digit < 6 && last_digit != 0)
            output += " and is less than 6 and not 0";
        Console.WriteLine(output);
    }
}
