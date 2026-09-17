using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sum of numbers*/
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                int r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine("sum is"+ sum);
            Console.ReadLine();

            /* Reverse of number */
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int summ = 0;
            while (num != 0)
            {
                int r = num % 10;
                summ = summ * 10 + r;
                num = num / 10;
                Console.WriteLine("reverse is" + summ);
                Console.ReadLine();
            }
        }
    }
}
