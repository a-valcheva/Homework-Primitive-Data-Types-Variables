using System;

class QuotesInStrings
{
    //Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    //Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value 
    //was correctly defined.
    static void Main(string[] args)
    {
        string quotes1 = "The \"use\" of quotations causes difficulties.";
        string quotes2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotes1 + "\n" + quotes2);
    }
}

