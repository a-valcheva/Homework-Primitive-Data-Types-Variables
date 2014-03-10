using System;

class NullValuesArithmetic
{
    //Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the 
    //console. Try to add some number or the null literal to these variables and print the result.
    static void Main(string[] args)
    {
        int? nullableInteger = null;
        double? floatNumber = null;
        Console.WriteLine("Null value: " + nullableInteger);
        Console.WriteLine("Null value: " + floatNumber);

        nullableInteger += 7;
        floatNumber += 4.5;
        Console.WriteLine("Number + null value: " + nullableInteger);
        Console.WriteLine("Number + null value: " + floatNumber);

        nullableInteger = 7;
        floatNumber = 4.5;
        Console.WriteLine("Number value: " + nullableInteger);
        Console.WriteLine("Number value: " + floatNumber);
    }
}

