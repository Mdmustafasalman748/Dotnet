using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{/* Exception Handling
  * Exception handling allows us to handle exceptions during runtime using try and catch blocks.
  * We can have nested try blocks.
  * We can have multiple catch blocks.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] objarray = new int[3];
                objarray[0] = 10;
                objarray[1] = 20;
                objarray[2] = 30;
                objarray[3] = 40;
                foreach (var item in objarray)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
}
    }
}
