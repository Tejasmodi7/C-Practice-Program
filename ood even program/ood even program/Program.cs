using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Enter the number-");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("number is Even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            Console.ReadLine();
        }
    }
}
