using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num1 =Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <=num1; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Fcatorail of Number"+num1+"is:");
            Console.WriteLine(fact);
            Console.ReadLine();

        }
    }
}
