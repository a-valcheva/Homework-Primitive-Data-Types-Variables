using System;

class EmployeeData
{
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    //First name
    //Last name
    //Age (0...100)
    //Gender (m or f)
    //Personal ID number (e.g. 8306112507)
    //Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use 
//descriptive names. Print the data at the console.
    static void Main(string[] args)
    {
        string firstName = "Todorka";
        string lastName = "Boeva";
        sbyte age = 30;
        char geneder = 'f';
        long idNumber = 8306112507;
        int empNumber = 27569999;

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", firstName, lastName, age, geneder, idNumber, empNumber);
    }
}

