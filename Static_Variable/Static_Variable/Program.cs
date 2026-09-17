using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable
{
    /*Static Variable - A variable declared with a keyword static is known as static variable.
     * Static variable is globally for all objects.
     * We can access static variable directly by class name.*/
public class Bank
    {
        public int AcNo;
        public string Name;
        public double Balance;
        public static double ROI = 12.5;
        public Bank(int AcNo, string Name, double Balance)
        {
            this.AcNo = AcNo;
            this.Name = Name;
            this.Balance = Balance;
        }
        public void Display()
        {
            Console.WriteLine("AcNo:{0} Name:{1} Balance:{2}",AcNo,Name,Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new Bank(100, "John", 500);
            obj.Display();
            Console.WriteLine(Bank.ROI);
            Console.ReadLine();
        }
    }
}
