using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_acount_in_bank
{
    public class Bank
    {
        public int AcNo;
        public string Name;
        public double Balance;
        public void CreateAccount(int acno, string name, double balance) /*Parameterized method*/
        {
            AcNo= acno;
            Name= name;
            Balance= balance;
        }
        public void show() /*Parameter less/ Default method*/
        {
            Console.WriteLine("AcNo:{0} Name:{1} Balance:{2}",AcNo,Name,Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank objbank = new Bank();
            objbank.CreateAccount(100, "John", 500);
            objbank.show();
            Console.ReadLine();
        }
    }
}
