﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int rem;
            int temp = num;

            while (num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            num = temp;
            if (num == result)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else 
            {
                Console.WriteLine("Number is Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
