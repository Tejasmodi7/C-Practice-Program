using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleConstuctor 
{
    class Car
    {
        string carModel;
        int carYear;

        public Car(string model,int year)
        {
            carModel = model;
            carYear = year;
        }
        public Car( int year,string model)
        {
            carModel = model;
            carYear = year;
        } 
        
        static void Main(string[] args)
        {
            Car myCar = new Car(2000,"Maruti");
            Console.WriteLine("model"+myCar.carModel);
            Console.WriteLine("year"+myCar.carYear);
            Console.ReadLine();


        }
    }
}
