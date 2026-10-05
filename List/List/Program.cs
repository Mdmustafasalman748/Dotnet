using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List 
             * It is a type of collection which comes under System.Collection.generic
             * It doesn't follow any rule.
             * In list we can use only a single datatype at a time.
             * We can remove any value from the list by using its index or directly by value.*/

            List<string> objli = new List<string>();
            objli.Add("Testing");
            objli.Add("Testing1");
            objli.Add("Testing2");
            objli.Add("testing3");
            objli.RemoveAt(1);
            objli.Remove("testing3");
            foreach (var item in objli)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
