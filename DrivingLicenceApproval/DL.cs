using System;
using System.Globalization;
using System.Transactions;

class Project
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Applicants: ");
        string[] applicants = new string[int.Parse(Console.ReadLine())];
        int count = 0;
        int ucount= 0;

        Console.WriteLine("Enter the names of applicants: ");
        for (int i=0;i<applicants.Length;i++) {
            applicants[i] = Console.ReadLine();
        }
        for(int j=0;j<applicants.Length;j++)
        {
            string str = applicants[j].Replace(" ", "");
            bool result = str.All(Char.IsLetter);

            if (result)
            {
                count++;
               // Console.WriteLine("Verified = {0}",count);
            }
            else
            {
                ucount++;
               // Console.WriteLine("Unverified = {0}", ucount);
            }
        }
        Console.WriteLine("Verified = {0}", count);
        Console.WriteLine("Unverified = {0}", ucount);

    }
}
