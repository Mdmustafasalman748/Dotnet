using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Stack 
             * It is one of the collection which follows Last In First Out (LIFO) rule.
             * Stack comes under System.Collections namespace*/

            Stack objstack = new Stack();
            objstack.Push("Testing");
            objstack.Push(123);
            objstack.Push(10.2);
            objstack.Push("Test");
            objstack.Pop();
            objstack.Pop();
            foreach (var item in objstack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}