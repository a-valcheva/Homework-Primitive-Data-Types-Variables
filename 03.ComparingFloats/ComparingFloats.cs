using System;

class ComparingFloats
{
    /*Write a program that safely compares floating-point numbers with precision eps = 0.000001. Note that we cannot directly 
     * compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we 
     * assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/
    static void Main(string[] args)
    {
        //This is the input.
        float firstA = 5.3f;
        float firstB = 6.01f;
        double secondA = 5.00000001;
        double secondB = 5.00000003;
        decimal thirdA = -0.0000007m;
        decimal thirdB = 0.00000007m;
        double fourthA = -4.999999;
        double fourthB = -4.999998;

        //This is the output
        Console.WriteLine("First pair: {0} and {1}\nSecond pair: {2} and {3}\nThird pair: {4} and {5}\nFourth pair: {6} and {7}", 
            firstA, firstB, secondA, secondB, thirdA, thirdB, fourthA, fourthB);
        Console.WriteLine();
        //I use separate method named CompareNumbers and type casting where it's needed instead of writing the same code four times.
        CompareNumbers((decimal)firstA, (decimal)firstB);
        CompareNumbers((decimal)secondA, (decimal)secondB);
        //I use the method for the third pair even though decimal numbers don't have comparison abnormalities and actually I 
        //don't need it for them.
        CompareNumbers(thirdA, thirdB);
        CompareNumbers((decimal)fourthA, (decimal)fourthB);
        //Example: (decimal)firstA - Explicit conversion between different data types(http://msdn.microsoft.com/en-us/library/ms173105.aspx)
    }

    //Separate method
    private static void CompareNumbers(decimal numberA, decimal numberB)
    {
        //This is the code that actually do the job. 
        //If you don't use separate method you need to write it four times - with every pair of numbers.
        if (Math.Abs(numberA - numberB) < 0.000001m)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
