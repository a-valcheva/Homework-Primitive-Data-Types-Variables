using System;

class DeclareVariables
{
    /*Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, 
     *long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number
     *to ensure it will fit in it. Try to compile the code. Submit the source code of your Visual Studio project as part of your 
     *homework submission.*/
    static void Main(string[] args)
    {
        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        int thirdNumber = 4825932;
        sbyte fourthNumber = 97;
        short fifthNumber = 10000;

        Console.WriteLine("First number: {0}\nSecond number: {1}\nThird number: {2}\nFourth number: {3}\nFifth number: {4}", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
    }
}

