using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Foreach - used for colelctions such as array*/
            /*Array - A collection of similar datatype*/
            int[] Marks = new int[3];
            int sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine("Enter the '" + (1+i) + "' subject marks");
                Marks[i] = int.Parse(Console.ReadLine());
                sum = sum + Marks[i];
            }
            Console.WriteLine(sum);
            foreach (int item in Marks)
            {
                sum = sum + item;
                Console.WriteLine(sum);
                Console.ReadLine();

            }
        }
    }
}


