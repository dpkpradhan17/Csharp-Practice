using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the input1: ");
        string i1= Console.ReadLine();
        Console.WriteLine("Enter the input2: ");
        string i2= Console.ReadLine();

        if(i1.Length == i2.Length)
        {
            int result = 0;
            char[] input1 = new char[i1.Length];
            char[] input2 = new char[i2.Length];
            for(int i=0; i<i1.Length; i++)
            {
                input1[i] = i1[i];
                input2[i] = i2[i];
            }
            
            for(int i = 0; i < i1.Length; i++)
            {
                int val1 = input1[i] - '0' ;
                int val2 = input2[i] - '0'  ;

                //Console.WriteLine(val1+ " " + val2);    

                int product = val1 * val2;
               // Console.WriteLine(product);
                result+= product;
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid inputs");
        }
        
        
    }
}