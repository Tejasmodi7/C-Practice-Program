using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaring and initializing the array 

            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };



            // Sort array in ascending order. 

            Array.Sort(arr);



            // reverse array 

            //Array.Reverse(arr);



            // print all element of array 

            foreach (int value in arr)
            {

                Console.Write(value + " ");

            }
            Console.ReadLine();

        }
    }
}
        