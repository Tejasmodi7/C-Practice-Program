﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i <10; i++)
            {
                int c = a + b;
               
                Console.WriteLine(c);
                a = b;
                b = c;
                
            }
            Console.ReadLine();
        }
    }
}
