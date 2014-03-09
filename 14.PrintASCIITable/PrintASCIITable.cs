using System;

class PrintASCIITable
{
    //Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints
    //the entire ASCII table of characters at the console (characters from 0 to 255). Note that some characters have a special 
    //purpose and will not be displayed as expected. You may skip them or display them differently. You may need to use 
    //for-loops (learn in Internet how).
    static void Main(string[] args)
    {
        for (int i = 0; i <= 127; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("{0}: {1}", i, symbol);
        }
    }
}

