using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methodoverloading
{
    class Program
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }

        public void Sum(float a, float b)
        {
            Console.WriteLine(a+b);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Sum(10,20);
            Console.ReadLine();
        }

      
    }
}
