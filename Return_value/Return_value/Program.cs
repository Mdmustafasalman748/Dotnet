using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_value
{
    public class Add
    {
        public int Display()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            return c;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Add a = new Add();
            int res=a.Display();
            Console.WriteLine(res);
            Console.ReadLine(); 

            /*Every program starts from main method
             * Syntax to declare a property: Access_specifier data_type variable_name
             */
        }
    }
}
