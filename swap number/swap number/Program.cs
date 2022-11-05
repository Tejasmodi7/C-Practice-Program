using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace swap_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;
           /* int temp;

            Console.WriteLine("Before Swapping a={0},b={1}",a,b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Swapping is done a={0},b={1}",a,b);*/

            Console.WriteLine("Before Swapping a={0},b={1}", a, b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Swapping is done a={0},b={1}", a, b);
            Console.ReadLine();



        }
    }
}
