using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter then Pin");
            int Pin = int.Parse(Console.ReadLine());
            if (Pin == 1234)
            {
            l: Console.WriteLine("1.Withdrawl 2.Deposit 3.MiniStatement 4.Exit");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("You have selected Withdrawl");
                        break;
                    case 2:
                        Console.WriteLine("You have selected Deposit");
                        break;
                    case 3:
                        Console.WriteLine("You have selected ministatement");
                        break;
                    case 4:
                        Console.WriteLine("You have selected the exit");
                        break;
                    default:
                        Console.WriteLine("Please select the correct option");
                        goto l;
                }
            }
            else
            {
                Console.WriteLine("Please! enter the correct pin");
            }
            Console.ReadLine();
        }
    }
}

