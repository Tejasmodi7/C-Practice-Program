using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursion
{
    class Program
    {
        /* int num = 1;
        void Counting()
        {
            if (num==11) 
            {
                return;  
            }
            Console.WriteLine(num);
            num++;
            Counting();
        }*/
           
            int num=Convert.ToInt32(Console.ReadLine());
            int result=1;
            int Factorial()
            {
                if (num == 0)
                {
                    return 1;
                }
                result = result * num;
                num--;
                Factorial();
                return result;
            }

        static void Main(string[] args)
        {
            Console.Write("Enter the Number-");
            /* Program obj=new Program();
            obj.Counting();*/
            Program obj = new Program();
            int factorail=obj.Factorial();
            Console.WriteLine("Factorial is"+factorail);
            Console.ReadLine();
        }
    }
}


       
    
