using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface IFirstInterface
    {
        void myMethod();
    }
    interface ISecondInterface
    {
        void myOtherMethod();
       
    }

    class Demo : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Hello");
        }
        public void myOtherMethod()
        {
           Console.WriteLine("Hello World");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo myObj = new Demo();
            myObj.myMethod();
            myObj.myOtherMethod();
            Console.ReadLine();
        }
    }
}
