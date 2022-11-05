using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
    public abstract class Animal
    {
        public abstract void AnimalSound();
       
        public void sleep()
        {
            Console.WriteLine("Zzzzzzz");
        }
    }
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says Wee Wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig mypig = new Pig();
            mypig.AnimalSound();
            mypig.sleep();
            Console.ReadLine();

        }
    }
}
