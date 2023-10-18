using System;


namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entwer the first number");
            int firstno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondno = Convert.ToInt32(Console.ReadLine());
            int ans = firstno + secondno;
            Console.WriteLine($"answer of {firstno} + {secondno} = {ans}");
            Console.ReadLine();

        }
    
    }

}
