using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number:");
                int n = int.Parse(Console.ReadLine());
                int res = 10 / n;
                Console.WriteLine(res);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                    }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
