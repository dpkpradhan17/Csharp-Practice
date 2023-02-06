// See https://aka.ms/new-console-template for more information

using System;

class Project
{
    static void Main()
    {
        Console.WriteLine("Enter your First Name");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Enter your Last Name");
        string LastName = Console.ReadLine();

        Console.WriteLine("Hello {0} {1}",FirstName,LastName);
    }
}