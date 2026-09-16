using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Stmts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;
            if (a > b)
            {
                Console.WriteLine("A is Greater than B");
            }
            else { 
                Console.WriteLine("B is Greater than A");
            }
            Console.ReadLine();
        }
    }
}
