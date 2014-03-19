using System;

class UnicodeValue
{
    //Declare a character variable and assign it with the symbol that has Unicode code 72, and then print it. Hint: first, use 
    //the Windows Calculator to find the hexadecimal representation of 72. The output should be “H”.
    static void Main(string[] args)
    {
        int code = 72;
        Console.WriteLine("The hexadecimal representation of code 72 is: {0:X}", code);
        char symbol = '\u0048';
        Console.WriteLine("The symbol is: {0}", symbol);
    }
}

