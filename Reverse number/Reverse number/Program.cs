using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number-");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int rem;
            
            while (num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;

            }
            Console.WriteLine("Reverse number is-"+result);
            Console.ReadLine();
        }
    }
}
