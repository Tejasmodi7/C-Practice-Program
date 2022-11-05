using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greater_integer_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 600;
            int b = 10;
            int c = 500;
{
                if (a > c)
                {
                    Console.WriteLine("a is greater");
                }
                else
                {
                    Console.WriteLine("c is greater");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is greater");
                }
                else
                {
                    Console.WriteLine("c is greater");
                }
            }

            Console.ReadLine();
        }
    }
    }

      /* if (a > b && a > c)
            {
                Console.WriteLine("a is greater");

            }
            else if (b > c && b > a)
            {
                Console.WriteLine("b is greater ");
            }
            else 
            {
                Console.WriteLine("c is greater");
            }*/