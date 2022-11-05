using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulation
{
    class Account
    {
        int accountBalance = 1000;

        public void setBalance(int amount)
        {
            accountBalance = amount;
        }
        public void getBalanace()
        {
            Console.WriteLine("Your account Balance is:"+accountBalance);
        }
    }
    class Program
    {
     
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.setBalance(10000);
            myAccount.getBalanace();
            Console.ReadLine();
        }
    }
}
