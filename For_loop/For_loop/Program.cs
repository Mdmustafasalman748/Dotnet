using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*For loop*/
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("MS");
            }
            Console.ReadLine();

            /*Display the table*/
            Console.WriteLine("Enter the number:");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} ={2}", n, i, (n * i));
            }
            Console.ReadLine();

            /*To display number of tables the user enters the number*/
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{ i}*{ j}={ i*j}");
                }
            }
            Console.ReadLine();
        }
    }
}
