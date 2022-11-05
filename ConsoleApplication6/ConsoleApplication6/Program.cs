using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Car
    {
       public string model;
       public string color;
       public int price;

       public void PrintCarInformation()
        {
            Console.WriteLine("Model" + model);
            Console.WriteLine("Color" + color);
            Console.WriteLine("Price" + price);
        }
    }
    class Maruti:Car
    {
       public float milage;

        void PrintMilage()
        {
            Console.WriteLine("milage" + milage);
        }
    

        public static void Main(string[] args)
    {

        Maruti obj = new Maruti();
        obj.model = "Aulto";
        obj.color = "white";
        obj.price = 200000;
        obj.milage = 22.5f;
        obj.PrintCarInformation();
        obj.PrintMilage();
        Console.ReadLine();

       

    }
  }
}
