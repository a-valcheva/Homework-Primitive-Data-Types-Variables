using System;

class ExchangeVariableValues
{
    //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. Print the 
    //variable values before and after the exchange.
    static void Main(string[] args)
    {
        int variableA = 5;
        int variableB = 10;
        Console.WriteLine("Before\n" + variableA);
        Console.WriteLine(variableB);

        int variableC = variableA;
        variableA = variableB;
        variableB = variableC;

        Console.WriteLine("After\n" + variableA);
        Console.WriteLine(variableB);
    }
}

