using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patternnumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i= 1; i<=4; i++)
            {
                for (int j = 1; j <=i ; j++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
