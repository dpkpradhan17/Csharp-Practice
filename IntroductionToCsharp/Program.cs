// See https://aka.ms/new-console-template for more information

using System;

class Project
{
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 10; i > 0; i--)
        {
            int product = n * i;
            Console.WriteLine("{n} * {i} = {2}", n, i, product);
        }
    }
}