using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    /*Constructor 
     * Constructor is a special kind of method which has same name as a class name.
     * We can have 'n' number of constructors in a class.
     * Constructor doesn't have return type.
     * It may or may not have parameters.
     * If it have parameters then it is parameterized constructor.
     * If it doesn't have parameters then it is default constructor.
     * Constructor is used to inilialize and object and stop reinitialization.
     * Constructor gets invoke implicitly whenever an object is created.
     * Types of constructors:
     * 1. Copy constructor
     * 2. Default constructor
     * 3. Parameterized constructor
     * 4. Private constructor
     * 5. Static constructor
     * Syntax: 1. Access Specifier 2. Constructor name (same as class name) 3. () 4.{}
     */

    public class Bank
    {
        public int AcNo;
        public string Name;
        public double Balance;
        public Bank(int acno, string name,double balance)
        {
            AcNo = acno;
            Name = name;
            Balance = balance;
        }
        public void Display()
        {
            Console.WriteLine("AcNo:{0} Name:{1} Balance:{2}", AcNo,Name, Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank objbank = new Bank(100, "john", 500);
            objbank.Display();
            Console.ReadLine();
        }
    }
}
