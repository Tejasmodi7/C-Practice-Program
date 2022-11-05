using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverRiding
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    class Dog:Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Eat();
            Console.ReadLine();
        }
    }
}
