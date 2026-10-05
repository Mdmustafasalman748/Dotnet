using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue objque = new Queue();
            objque.Enqueue("Test");
            objque.Enqueue(123);
            objque.Enqueue(10.2);
            objque.Enqueue("Testing");
            objque.Dequeue();
            objque.Dequeue();
            foreach (var item in objque)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
