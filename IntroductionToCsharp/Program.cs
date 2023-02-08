// See https://aka.ms/new-console-template for more information

using System;

class Project
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();

        bool result = input.All(Char.IsLetter);

        if(result)
        {
            Console.Write(input);
            for(int i=0;i<input.Length;i++)
            {
                int val = input[i];
                if(val == 122 || val == 90)
                {
                    val -= 25;
                }
                /*else if(val == 90)
                {
                    val -= 25;
                }*/
                else if (i%2 == 0)
                {
                    val += 1;
                }
              //Console.WriteLine(val);
              Console.Write(Convert.ToChar(val));
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}