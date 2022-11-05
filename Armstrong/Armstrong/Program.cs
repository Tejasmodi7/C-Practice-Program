using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int cube;
            int rem;
            int temp = num;

            while (num != 0)
            { 
                rem=num%10;
                cube = rem * rem * rem;
                result = result + cube;
                num = num / 10;

            }
            num = temp;
            if (num == result)
            { Console.WriteLine("Number is Armstrong"); }
            else
            { Console.WriteLine("Number isNot Armstrong"); }
            Console.ReadLine();
        }
    }
}
