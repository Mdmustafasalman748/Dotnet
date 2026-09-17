using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Method
{
    /*Static Class - A class which is declared with a keyword static is known as static class.
     * Static class contains only static members.
     * We cannot create object and reference of a static class.
     * 
     * Static Constructor - A constructor which is declared with a keyword static is known as static constructor.
     * *Static constructor is used to initialize static variables.
     * *We can have only one static constructor in a class.
     * *It doesn't have return type and access specifier.
     * *It should be parameter less.
     * *It is not possible to overload static constructor.
     * *Static constructor gets invoke implicitly before the creation of an object.
     * 
     * Static Method - A method declared with a keyword static is known as static method.
     * Static method can be accessed directly by class name.
     */

    public static class Bank
    {
        public static string Name;
        static Bank()
        {
            Name = "This is static variable in static constructor";
        }
        public static void Display()
        {
            Console.WriteLine("This is static method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bank.Name);
            Bank.Display();
            Console.ReadLine();
        }
    }
}
