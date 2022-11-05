using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern1star
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
          /*  for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }*/
            Console.ReadLine();
        }
    }
}
