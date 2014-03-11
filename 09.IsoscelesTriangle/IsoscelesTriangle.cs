using System;
using System.Text;

class IsoscelesTriangle
{
    //Write a program that prints an isosceles triangle of 9 copyright symbols ©
    //   ©
    //  © ©
    // ©   ©
    //© © © ©
    //Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character 
    //encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © 
    //symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
    static void Main(string[] args)
    {
        //IMPORTANT Check your console font - if it's raster change it to Consolas with appropriate size or Lucida Console!
        //If you don't want to do that put the next line in a comment.
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = '\u00A9';
        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", copyRight);
    }
}

